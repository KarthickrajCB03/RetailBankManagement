using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using AccountMicroservice.Model;
using AccountMicroservice.Models;
using AccountMicroservice.Repository;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AccountMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        Uri baseAddress = new Uri("https://localhost:44304/api");   //Port No.
        HttpClient client;

        readonly log4net.ILog _log4net;
        
        public AccountController()
        {
            client = new HttpClient();
            client.BaseAddress = baseAddress;
            _log4net = log4net.LogManager.GetLogger(typeof(AccountController));


        }
        static int acid = 1;
        public static List<customeraccount> customeraccounts = new List<customeraccount>()
        {
            new customeraccount{custId=1,CAId=101,SAId=102}
        };
        public static List<CurrentAccount> currentAccounts = new List<CurrentAccount>()
        {
            new CurrentAccount{CAId=101,CBal=5000}
        };
        public static List<SavingsAccount> savingsAccounts = new List<SavingsAccount>()
        {
            new SavingsAccount{SAId=102,SBal=2000}
        };
        // GET: api/<AccountController>
        [HttpGet]
        [Route("getCurrentAccountList")]
        public IActionResult GetCurrent()
        {
            return Ok(currentAccounts);
        }

        [HttpGet]
        [Route("getSavingAccountList")]
        public IActionResult GetSavings()
        {
            return Ok(savingsAccounts);
        }

        [HttpPost]
        [Route("createAccount")]
        public customeraccount createAccount([FromBody] Customer customer)
        {

            _log4net.Info("Account Created");
            customeraccount a = new customeraccount
            {
                custId = customer.id,
                CAId = (customer.id * 100) + acid,
                SAId = (customer.id * 100) + (acid + 1)
            };
            customeraccounts.Add(a);
            var cust = customeraccounts.Find(c => c.custId == customer.id);
            CurrentAccount ca = new CurrentAccount
            {
                CAId = (customer.id * 100) + acid,
                CBal = 5000.00
            };
            currentAccounts.Add(ca);
            SavingsAccount sa = new SavingsAccount
            {
                SAId = (customer.id * 100) + (acid + 1),
                SBal = 2000.00
            };
            savingsAccounts.Add(sa);
            Uri baseAddress = new Uri("https://localhost:44301/api");   //Port No.
            HttpClient client = new HttpClient();
            client.BaseAddress = baseAddress;
            var user = new User {UserId=customer.id,Password="12345",Roles="Customer" };
            string data = JsonConvert.SerializeObject(user);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PostAsync(client.BaseAddress + "/Token/createUser/", content).Result;
            return cust;
        }

        // GET api/<AccountController>/5
        [HttpGet]
        [Route("getCustomerAccounts/{id}")]
        public ActionResult<List<dwacc>> getCustomerAccounts(int id)
        {

            //var customeraccounts = GetListRep.GetCustomeraccountsList();
            List<dwacc> accList = new List<dwacc>();
            _log4net.Info(" Got Customer Account");
            var a = customeraccounts.Find(c => c.custId == id);
            var ca = currentAccounts.Find(cac => cac.CAId == a.CAId);
            var sa = savingsAccounts.Find(sac => sac.SAId == a.SAId);
            dwacc dobj = new dwacc();
            dobj.AccountId = ca.CAId;
            dobj.Balance = int.Parse(ca.CBal.ToString());
            accList.Add(dobj);
            dwacc dobj1 = new dwacc();
            dobj1.AccountId = sa.SAId;
            dobj1.Balance = int.Parse(sa.SBal.ToString());
            accList.Add(dobj1);
            return accList;
            //return "Current Account(" + ca.CAId.ToString() + "):: Rs." + ca.CBal.ToString() + ".00\n" + "Savings Account(" + sa.SAId.ToString() + "):: Rs." + sa.SBal.ToString()+".00";
        }

        // POST api/<AccountController>
        
        [HttpGet]
        [Route("getAccount/{id}")]
        public ActionResult<ArrayList> getAccount(int id)
        {
            //GetListRep ob = new GetListRep();
            // var customeraccounts = GetListRep.GetCustomeraccountsList();
            ArrayList accList = new ArrayList();
            _log4net.Info(" Getting Account Info");
            if (id % 2 != 0)
            {
                var ca = currentAccounts.Find(a => a.CAId == id);
                //return "Current Account(" + ca.CAId + "):: Rs." + ca.CBal + ".00";
                accList.Add(new { ca.CAId, ca.CBal });
                
                return accList;
            }
            
            var sa = savingsAccounts.Find(a => a.SAId == id);
            //return "Savings Account(" + sa.SAId + "):: Rs." + sa.SBal + ".00";
            accList.Add(new { sa.SAId, sa.SBal });
            return accList;
            
        }
        [HttpGet]
        [Route("getAccountStatement/{AccountId}/{from_date}/{to_date}")]
        public IEnumerable<Statement> getAccountStatement(int AccountId,int from_date,int to_date)
        {
            _log4net.Info("Account Statement Shown");
           // GetListRep ob = new GetListRep();
            var ac = GetListRep.GetAccountStatementsList();
            if(from_date!=0 || to_date!=0)
            {
                var accs = ac.Find(a => a.AccId == AccountId);
                var s = accs.Statements;
                if (s == null)
                    return null;
                else
                {
                    foreach (var n in s)
                    {
                        if (n.date >= from_date && n.date <= to_date)
                        {
                            return s;
                        }
                    }
                }
            }
            else
            {
                return null;
            }
            var accs1 = ac.Find(a => a.AccId == AccountId);
            if (accs1 == null)
                return null;
            var s1 = accs1.Statements;
            if (s1 == null)
                return null;
            else
            {
                foreach (var n in s1)
                {
                    if (n.date > 01092020 && n.date < 30092020)
                    {
                        return s1;
                    }
                }
            }
            return null;
        }
        [HttpPost]
        [Route("deposit")]
        public ActionResult<Depositwithdraw> deposit([FromBody] dwacc value)
        {
            //GetListRep ob = new GetListRep();
            //var customeraccounts = GetListRep.GetCustomeraccountsList();
           
            string data = JsonConvert.SerializeObject(value);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");

            HttpResponseMessage response = client.PostAsync(client.BaseAddress + "/Transaction/deposit/", content).Result;
            if (response.IsSuccessStatusCode)
            {
                _log4net.Info(" Amount Deposited ");
                string data1 = response.Content.ReadAsStringAsync().Result;
                if (data1 == "Success")
                {
                    if(value.AccountId%2==0)
                    {
                        var sa = savingsAccounts.Find(a => a.SAId == value.AccountId);
                        if (sa != null)
                        {
                            sa.SBal += value.Balance;
                            return new Depositwithdraw { AccountID = sa.SAId, Message = "Deposited Successfully", Balance = sa.SBal };
                            //return "Deposited Successfully.New Account Rs." + sa.SBal + ".00";
                        }
                        else
                            return new Depositwithdraw { AccountID = value.AccountId, Message = "Deposit Failed, Enter Correct Account ID", Balance = value.Balance };
                    }
                    var ca = currentAccounts.Find(a => a.CAId == value.AccountId);
                    if (ca != null)
                    {
                        ca.CBal += value.Balance;
                        return new Depositwithdraw { AccountID = ca.CAId, Message = "Deposited Successfully", Balance = ca.CBal };
                        //return "Deposited Successfully.New Account Rs."+ca.CBal+".00";
                    }
                    else
                        return new Depositwithdraw { AccountID = value.AccountId, Message = "Deposit Failed, Enter Correct Account ID", Balance = value.Balance };
                }
                _log4net.Info("Deposited Failed");
                return new Depositwithdraw { AccountID = value.AccountId, Message = "Deposit Failed, Enter Correct Account ID", Balance = value.Balance };
            }
            _log4net.Info("Deposited Failed");
            return new Depositwithdraw { AccountID = value.AccountId, Message = "Deposit Failed, Enter Correct Account ID", Balance = value.Balance };
        }
        [HttpPost]
        [Route("withdraw")]
        public ActionResult<Depositwithdraw> Withdraw([FromBody] dwacc value)
        {
            //GetListRep ob = new GetListRep();
            var customeraccounts = GetListRep.GetCustomeraccountsList();
            
            string data = JsonConvert.SerializeObject(value);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");

            HttpResponseMessage response = client.PostAsync(client.BaseAddress + "/Transaction/withdraw/", content).Result;
            if (response.IsSuccessStatusCode)
            {
                _log4net.Info("Amount Withdrawn");
                string data1 = response.Content.ReadAsStringAsync().Result;
                if (data1 == "No Warning")
                {
                    if (value.AccountId % 2 == 0)
                    {
                        var sa = savingsAccounts.Find(a => a.SAId == value.AccountId);
                        if (sa != null)
                        {
                            sa.SBal = sa.SBal - value.Balance;
                            if (sa.SBal >= 0)
                            {
                                if (sa.SBal >= 1000)
                                {
                                    return new Depositwithdraw { AccountID = sa.SAId, Message = "Withdraw Successfull", Balance = sa.SBal };
                                }
                                else
                                {
                                    return new Depositwithdraw { AccountID = sa.SAId, Message = "Withdraw Successfull,but service charge will be deducted at the end of month since Balance is less than 1000", Balance = sa.SBal };
                                }
                            }

                            else
                            {
                                sa.SBal = sa.SBal + value.Balance;
                                return new Depositwithdraw { AccountID = sa.SAId, Message = "Withdraw Failed due to Insufficient Fund", Balance = sa.SBal };
                                //return "Insufficient Fund";
                            }
                        }
                        else
                            new Depositwithdraw { AccountID = value.AccountId, Message = "Withdraw Failed , Enter Correct Account ID", Balance = value.Balance };

                    }

                    var car = currentAccounts.Find(a => a.CAId == value.AccountId);
                    if (car != null)
                    {
                        car.CBal = car.CBal - value.Balance;
                        if (car.CBal >= 0)
                        {
                            if (car.CBal >= 1000)
                                return new Depositwithdraw { AccountID = car.CAId, Message = "Withdraw Successfull", Balance = car.CBal };
                            else
                                return new Depositwithdraw { AccountID = car.CAId, Message = "Withdraw Successfull,but service charge will be deducted at the end of month since Balance is less than 1000", Balance = car.CBal };
                            //return "Withdrawn Successfully.New Balance Rs." + car.CBal + ".00";
                        }
                        else
                        {
                            car.CBal = car.CBal + value.Balance;
                            //return "Insufficient Fund";
                            return new Depositwithdraw { AccountID = car.CAId, Message = "Withdraw Failed due to Insufficient Fund", Balance = car.CBal };
                        }

                    }
                    else
                        new Depositwithdraw { AccountID = value.AccountId, Message = "Withdraw Failed, Enter Correct Account ID", Balance = value.Balance };
                }
                //If Warning Returned...
                if (value.AccountId % 2 == 0)
                {
                    var sa = savingsAccounts.Find(a => a.SAId == value.AccountId);
                    if (sa != null)
                    {
                        sa.SBal = sa.SBal - value.Balance;
                        if (sa.SBal >= 0)
                            return new Depositwithdraw { AccountID = sa.SAId, Message = "Withdraw Successfull,but service charge will be deducted at the end of month since Balance is less than 1000", Balance = sa.SBal };
                        //return "Withdrawn Successfully.New Balance Rs." + sa.SBal + ".00 but service charge will be deducted at the end of month";

                        else
                        {
                            sa.SBal = sa.SBal + value.Balance;
                            //return "Insufficient Fund";
                            return new Depositwithdraw { AccountID = sa.SAId, Message = "Withdraw Failed due to Insufficient Fund", Balance = sa.SBal };

                        }
                    }
                    else
                        new Depositwithdraw { AccountID = value.AccountId, Message = "Withdraw Failed, Enter Correct Account ID", Balance = value.Balance };
                }
                var ca = currentAccounts.Find(a => a.CAId == value.AccountId);
                if (ca != null)
                {
                    ca.CBal = ca.CBal - value.Balance;
                    if (ca.CBal >= 0)
                        return new Depositwithdraw { AccountID = ca.CAId, Message = "Withdraw Successfull,but service charge will be deducted at the end of month since Balance is less than 1000", Balance = ca.CBal };
                    ///return "Withdrawn Successfully.New Balance Rs." + ca.CBal + ".00 but service charge will be deducted at the end of month";
                    else
                    {
                        ca.CBal = ca.CBal + value.Balance;
                        return new Depositwithdraw { AccountID = ca.CAId, Message = "Withdraw Failed due to Insufficient Fund", Balance = ca.CBal };
                        //return "Insufficient Fund";
                    }


                }
                else
                    new Depositwithdraw { AccountID = value.AccountId, Message = "Withdraw Failed , Enter Correct Account ID", Balance = value.Balance };
            }
            return new Depositwithdraw { AccountID = value.AccountId, Message = "Withdraw Failed, Enter Correct Account ID", Balance = value.Balance };
            //return "Link Failure";
        }

        [HttpPost]
        [Route("transfer")]
        public ActionResult<transactionmsg> Transfer([FromBody] transfers value)
        {
            //GetListRep ob = new GetListRep();
            var customeraccounts = GetListRep.GetCustomeraccountsList();
        //    var currentAccounts = ob.GetCurrentAccountsList();
          //  var savingsAccounts = ob.GetSavingsAccountsList();
            double sb = 0.0, db = 0.0;
            string data = JsonConvert.SerializeObject(value);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            if(value.source_accid==value.destination_accid)
                return new transactionmsg { sbal = sb, rbal = db, transferStatus = "Transaction Failed, Enter Correct Account ID" };
            if (value.source_accid % 2 == 0)
            {
                var sas = savingsAccounts.Find(a => a.SAId == value.source_accid);
                if (sas==null)
                    return new transactionmsg { sbal = sb, rbal = db, transferStatus = "Transaction Failed , Enter Correct Account ID" };
            }
            else
            {
                var cas = currentAccounts.Find(a => a.CAId == value.source_accid);
                if (cas == null)
                    return new transactionmsg { sbal = sb, rbal = db, transferStatus = "Transaction Failed, Enter Correct Account ID" };
            }
            if (value.destination_accid % 2 == 0)
            {
                var sas = savingsAccounts.Find(a => a.SAId == value.destination_accid);
                if (sas == null)
                    return new transactionmsg { sbal = sb, rbal = db, transferStatus = "Transaction Failed, Enter Correct Account ID" };
            }
            else
            {
                var cas = currentAccounts.Find(a => a.CAId == value.destination_accid);
                if (cas == null)
                    return new transactionmsg { sbal = sb, rbal = db, transferStatus = "Transaction Failed, Enter Correct Account ID" };
            }
            HttpResponseMessage response = client.PostAsync(client.BaseAddress + "/Transaction/transfer/", content).Result;
            if (response.IsSuccessStatusCode)
            {
                _log4net.Info("Amount Transferred");
                string data1 = response.Content.ReadAsStringAsync().Result;
                if (data1 == "No Warning")
                {
                    if (value.source_accid % 2 == 0)
                    {
                        var sas = savingsAccounts.Find(a => a.SAId == value.source_accid);
                        sas.SBal = sas.SBal - value.amount;
                        if (sas.SBal >= 0)
                            sb = sas.SBal;
                        else
                        {
                            sas.SBal = sas.SBal + value.amount;
                            return new transactionmsg { sbal = sas.SBal, rbal = db, transferStatus = "Transaction failed,due to Insufficient Balance." };
                            //return "Insufficient Fund";
                        }
                    }
                    else
                    {
                        var cas = currentAccounts.Find(a => a.CAId == value.source_accid);
                        cas.CBal = cas.CBal - value.amount;
                        if (cas.CBal >= 0)
                            sb = cas.CBal;
                        else
                        {
                            cas.CBal = cas.CBal + value.amount;
                            return new transactionmsg { sbal = cas.CBal, rbal = db, transferStatus = "Transaction failed,due to Insufficient Balance." };
                            //return "Insufficient Fund";
                        }
                            
                    }
                    
                    if (value.destination_accid % 2 == 0)
                    {
                        var sa = savingsAccounts.Find(a => a.SAId == value.destination_accid);
                        sa.SBal = sa.SBal + value.amount;
                        db = sa.SBal;
                    }
                    else
                    {
                        var ca = currentAccounts.Find(a => a.CAId == value.destination_accid);
                        ca.CBal = ca.CBal + value.amount;
                        db = ca.CBal;
                    }
                    
                    return new transactionmsg { sbal = sb, rbal = db, transferStatus = "Success" };
                    //return "Sender Account Balance Rs." + sb + ".00\n" + "Receiver Account Balance Rs." + db + ".00";
                }
                else
                {
                    if (value.source_accid % 2 == 0)
                    {
                        var sas = savingsAccounts.Find(a => a.SAId == value.source_accid);
                        sas.SBal = sas.SBal - value.amount;
                        if (sas.SBal >= 0)
                            sb = sas.SBal;
                        else
                        {
                            sas.SBal = sas.SBal + value.amount;
                            return new transactionmsg { sbal = sb, rbal = db, transferStatus = "Transaction failed,due to Insufficient Balance." };
                            //return "Insufficient Fund";
                        }
                            
                    }
                    else
                    {
                        var cas = currentAccounts.Find(a => a.CAId == value.source_accid);
                        cas.CBal = cas.CBal - value.amount;
                        if (cas.CBal >= 0)
                            sb = cas.CBal;
                        else
                        {
                            cas.CBal = cas.CBal + value.amount;
                            return new transactionmsg { sbal = sb, rbal = db, transferStatus = "Transaction failed,due to Insufficient Balance." };
                            //return "Insufficient Fund";
                        }
                           
                    }
                    if (value.destination_accid % 2 == 0)
                    {
                        var sa = savingsAccounts.Find(a => a.SAId == value.destination_accid);
                        sa.SBal = sa.SBal + value.amount;
                        db = sa.SBal;
                    }
                    else
                    {
                        var ca = currentAccounts.Find(a => a.CAId == value.destination_accid);
                        ca.CBal = ca.CBal + value.amount;
                        db = ca.CBal;
                    }
                    //return "Sender Account Balance Rs." + sb + ".00\n" + "Receiver Account Balance Rs." + db + ".00\n but service charge will be deducted at the end of month from your account";
                    return new transactionmsg { sbal = sb, rbal=db,transferStatus= "Success,but service charge will be deducted at the end of month from your account due to balance less than 1000" };

                }
                
            }
            // return "Link Failure";
            return new transactionmsg { sbal = sb, rbal = db, transferStatus = "Transaction Failed, Enter Correct Account ID" };
        }
    }
}
