using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using WebApi.Models;
using WebApi.Services;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IDataService<Order, int> ordService;

        public OrdersController(IDataService<Order, int> service)
        {
            ordService = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var response = ordService.Get();
            return Ok(response);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var response = ordService.Get(id);
            return Ok(response);
        }
        [HttpPost]
        public IActionResult Post(Order data)
        {
            var response = ordService.Create(data);
            return Ok(response);    
        }
        [HttpPut]
        public IActionResult Put(int id, Order data)
        {
            var response = ordService.Update(id, data);
            return Ok(response);
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var response = ordService.Delete(id);
            return Ok(response);
        }
    }
}
