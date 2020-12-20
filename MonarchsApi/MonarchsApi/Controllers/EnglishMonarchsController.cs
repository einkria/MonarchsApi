using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
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
        public IList<Monarch> GetMonarches()
        {
            return _service.GetMonarchs();
        }
    }
}