using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Safe365__Proj.Model;
using Safe365__Proj.Model.DataManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Safe365__Proj.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {

        private ICustomerManager _customerManager;

        public CustomerController(ICustomerManager customerManager)
        {
            _customerManager = customerManager;
        }

        [HttpGet]
        public ActionResult Index()
        {
            IEnumerable<Customer> customers = _customerManager.GetAll();
            return Ok(customers);
        }

        [Route("Details/{id}")]
        public ActionResult Details(int id)
        {
            Customer objCustomer = _customerManager.Get(id);
            return Ok(objCustomer);
        }

       
        [Route("Create")]
        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            _customerManager.Add(customer);
            return Ok(customer);
        }
        
        
        [Route("Edit")]
        [HttpPost]
        public ActionResult Edit(Customer customer)
        {
            _customerManager.Update(customer);
            return Ok(customer);
        }

        [Route("Delete/{id}")]
        public ActionResult Delete(int id)
        {

            Customer objCustomer = _customerManager.Get(id);
            _customerManager.Delete(objCustomer);

            return Ok(objCustomer);
        }

        
    }
}
