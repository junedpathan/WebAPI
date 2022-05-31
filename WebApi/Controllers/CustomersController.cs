using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using WebApi.Models;
using WebApi.Services;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly IDataService<Customer, int> custService;

        public CustomersController(IDataService<Customer, int> service)
        {
            custService = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var response = custService.Get();
            return Ok(response);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var response = custService.Get(id);
            return Ok(response);
        }
        [HttpPost]
        public IActionResult Post(Customer data)
        {
            var response = custService.Create(data);
            return Ok(response);
        }
        [HttpPut]
        public IActionResult Put(int id, Customer data)
        {
            var response = custService.Update(id, data);
            return Ok(response);
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var response = custService.Delete(id);
            return Ok(response);
        }
    }
}
