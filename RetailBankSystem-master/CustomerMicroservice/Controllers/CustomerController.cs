using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerMicroservice.Models;
using CustomerMicroservice.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using log4net;

namespace CustomerMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        static readonly ILog _log4net = log4net.LogManager.GetLogger(typeof(CustomerController));
        
        
        [HttpGet]
        [Route("getCustomerDetails/{id}")]
        public IActionResult getCustomerDetails(int id)
        {
            _log4net.Info("Get Customer Details is called with id:" + id);
            try
            {
                var obj = CustomerRep.getCustomerDetails(id);
                if (obj == null)
                {
                    return NotFound();
                }
                return Ok(obj);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPost]
        [Route("createCustomer")]
        public IActionResult createCustomer([FromBody] Customer customer)
        {
            _log4net.Info("Creation of customer is initiated");
            try
            {
                var obj = CustomerRep.createCustomer(customer);
                if (obj == null)
                {
                    _log4net.Info("Error in Customer Creation.");
                    return NotFound();
                }
                _log4net.Info("New Customer account is created");
                return Ok(obj);
                
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
