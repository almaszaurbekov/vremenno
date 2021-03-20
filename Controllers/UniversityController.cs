using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Data;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UniversityController : ControllerBase
    {
        private readonly ILogger<UniversityController> _logger;
        private readonly IUniversityRepo _universityRepo;

        public UniversityController(ILogger<UniversityController> logger, IUniversityRepo universityRepo)
        {
            _logger = logger;
            _universityRepo = universityRepo;
        }

        [HttpGet("{id}")]
        public University Get(int id)
        {
            return new University() { Id = id };
        }
    }
}
