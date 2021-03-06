using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using BankPortalMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BankPortalMVC.Controllers
{
    public class CustomerController : Controller
    {
        Uri baseAddress = new Uri("https://localhost:44379/api");
        HttpClient client;
        public CustomerController()
        {
            client = new HttpClient();
            client.BaseAddress = baseAddress;
        }
        public IActionResult Index()
        {
            string token = TokenInfo.StringToken;
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            int id = TokenInfo.UserID;
            var ac = new List<dwacc>();
            HttpResponseMessage response = client.GetAsync(client.BaseAddress + "/Account/getCustomerAccounts/" + id).Result;
            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                ac = JsonConvert.DeserializeObject<List<dwacc>>(data);
            }
            return View(ac);
        }
        public IActionResult Deposit()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Deposit(dwacc accountBalance)
        {
            string data = JsonConvert.SerializeObject(accountBalance);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PostAsync(client.BaseAddress + "/Account/deposit/", content).Result;
            if (response.IsSuccessStatusCode)
            {
                string data1 = response.Content.ReadAsStringAsync().Result;
                Depositwithdraw ob4 = JsonConvert.DeserializeObject<Depositwithdraw>(data1);
                return RedirectToAction("DepositStatus", "Customer",ob4);
            }
            return BadRequest();
        }
        public IActionResult DepositStatus(Depositwithdraw ob4)
        {
            return View(ob4);
        }
        public IActionResult Withdraw()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Withdraw(dwacc accountBalance)
        {
            string data = JsonConvert.SerializeObject(accountBalance);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PostAsync(client.BaseAddress + "/Account/withdraw/", content).Result;
            if (response.IsSuccessStatusCode)
            {
                string data1 = response.Content.ReadAsStringAsync().Result;
                Depositwithdraw ob4 = JsonConvert.DeserializeObject<Depositwithdraw>(data1);
                return RedirectToAction("WithdrawStatus", "Customer",ob4);
            }
            return BadRequest();
        }
        public IActionResult WithdrawStatus(Depositwithdraw ob4)
        {
            return View(ob4);
        }
        public IActionResult transfer()
        {
            return View();
        }
        [HttpPost]
        public IActionResult transfer(transfers accountBalance)
        {
            string data = JsonConvert.SerializeObject(accountBalance);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PostAsync(client.BaseAddress + "/Account/transfer/", content).Result;
            if (response.IsSuccessStatusCode)
            {
                string data1 = response.Content.ReadAsStringAsync().Result;
                transactionmsg ob4 = JsonConvert.DeserializeObject<transactionmsg>(data1);
                return RedirectToAction("TransferStatus", "Customer",ob4);
            }
            return BadRequest();
        }
        public IActionResult TransferStatus(transactionmsg ob4)
        {
            return View(ob4);
        }
        public IActionResult AccountStatement()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AccountStatement(AccDetState accDetState)
        {
                return RedirectToAction("AccountStatementStatus", accDetState);
        }
        public IActionResult AccountStatementStatus(AccDetState accDetState)
        {
            int AccountId = accDetState.AccountId;
            int from_date = accDetState.from_date;
            int to_date = accDetState.to_date;
            HttpResponseMessage response = client.GetAsync(client.BaseAddress + "/Account/getAccountStatement/" + AccountId+"/"+from_date+"/"+to_date).Result;
            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                if (!string.IsNullOrEmpty(data))
                {
                    List<Statement> ac = JsonConvert.DeserializeObject<List<Statement>>(data);
                    return View(ac);
                }
            }
            return View("AccountStatementError");
        }
        public IActionResult AccountStatementError()
        {
            return View();
        }
    }
}
