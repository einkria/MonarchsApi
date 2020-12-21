using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

using MonarchsApi.Services;
using MonarchsApi.Models;

namespace MonarchsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnglishMonarchsController : ControllerBase
    {
        private readonly IMonarchsService _service;

        public EnglishMonarchsController(IMonarchsService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IList<Monarch>> GetMonarchs()
        {
            Console.WriteLine("Endpoint: GetMonarchs() - called");
            var monarchs = _service.GetMonarchs();

            if (monarchs == null)
            {
                Console.WriteLine("Endpoint: GetMonarchs() - returned with error, data could not be fetched");
                return StatusCode(500);
            }

            Console.WriteLine("Endpoint: GetMonarchs() - returned with data");
            return Ok(monarchs);
        }
    }
}