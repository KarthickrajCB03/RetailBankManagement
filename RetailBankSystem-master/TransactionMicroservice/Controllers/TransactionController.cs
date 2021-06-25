using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TransactionMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        Uri baseAddress = new Uri("https://localhost:44356/api");   //Port No.
        HttpClient client;

        public TransactionController()
        {
            client = new HttpClient();
            client.BaseAddress = baseAddress;

        }
        
        [HttpPost]
        [Route("deposit")]
        public string deposit([FromBody] dwacc value)
        {
            return "Success";
        }
        [HttpPost]
        [Route("withdraw")]
        public string Withdraw([FromBody] dwacc value)
        {
            string data = JsonConvert.SerializeObject(value);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            HttpResponseMessage response;
            if (value.AccountId % 2 == 0)
            {
                response = client.PostAsync(client.BaseAddress + "/Rules/evaluateMinBalSavings/", content).Result;
            }
            else
            {
               response = client.PostAsync(client.BaseAddress + "/Rules/evaluateMinBalCurrent/", content).Result;
            }
            if (response.IsSuccessStatusCode)
            {
                string data1 = response.Content.ReadAsStringAsync().Result;
                if (data1=="Warning")
                {
                    return "Warning";
                }
                return "No Warning";
            }
            return "Link Failure";
        }
        [HttpPost]
        [Route("transfer")]
        public string Transfer([FromBody] transfers value)
        {
            dwacc sa = new dwacc
            {
                AccountId = value.source_accid,
                Balance = value.amount
            };
            string data = JsonConvert.SerializeObject(sa);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");

            HttpResponseMessage response;
            if (sa.AccountId % 2 == 0)
            {
                response = client.PostAsync(client.BaseAddress + "/Rules/evaluateMinBalSavings/", content).Result;
            }
            else
            {
                response = client.PostAsync(client.BaseAddress + "/Rules/evaluateMinBalCurrent/", content).Result;
            }
            if (response.IsSuccessStatusCode)
            {
                string data1 = response.Content.ReadAsStringAsync().Result;
                if(data1=="Warning")
                {
                    return "Warning";
                }
                return "No Warning";
            }
            return "Link Failure";
        }
    }
}
