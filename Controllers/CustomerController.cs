using System.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JApi.Data.Models;
using JApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase,IControllerApi<Customer>
    {

        private readonly CustomerServices _services;
        public CustomerController(AppDbContext _appDb)
        {
                _services = new CustomerServices(_appDb);
        }
        [HttpGet]
        public ActionResult<List<Customer>> GetAll() =>  _services.Get();

        [HttpGet("{id}")]
        public  ActionResult<Customer> Get(int id) {
            var customer = _services.Get(id);
            if(customer==null)
                return NotFound();

            return customer;

        }
        
        [HttpPost]
        public IActionResult Create(Customer customer)
        {
            _services.Add(customer);
            return CreatedAtAction(nameof(Create),new {Id = customer.Id},customer);
        }
        [HttpDelete("id")]
        public IActionResult Delete(int id)
        {
            var result = _services.Get(id);
            if(result is null)
                return NotFound();
            _services.Delete(result);
            return NoContent();

        }
        [HttpPut("id")]
        public IActionResult Update(int id, Customer request)
        {
            if(id != request.Id)
                return BadRequest();
            var result = _services.Get(id);
            if(result is null)
                return NotFound();

            _services.Update(request);
            return NoContent();

        }
    }
}