using AccountMicroservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccountMicroservice.Repository
{
    public static class GetListRep
    {
       public static List<AccountStatement> accountStatements = new List<AccountStatement>()
            {
                new AccountStatement{AccId=101,
                    Statements= new List<Statement>()
                    {
                    
                    new Statement{date=26062021,Narration="Deposit from Bank",refno=21345,valueDate=04022020,withdrawal=0.00,deposit=5000.00,closingBalance=5000.00}
                    }
                },
                new AccountStatement{AccId=102,
                    Statements= new List<Statement>()
                    {
                    

                    new Statement{date=26022021,Narration="Deposit from Bank",refno=21345,valueDate=04022020,withdrawal=0.00,deposit=2000.00,closingBalance=2000.00}
                    }
                }
            };
        public static List<AccountStatement> GetAccountStatementsList()
        {
            
            return accountStatements;
        }

   

        public static List<customeraccount> GetCustomeraccountsList()
        {
            List<customeraccount> customeraccounts = new List<customeraccount>()
            {
                new customeraccount{custId=1,CAId=101,SAId=102}
            };
            return customeraccounts;
        }

      
    }
}
