using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PoprawaKolos.Models;

namespace PoprawaKolos.Controllers
{

    [Route("api/temp")]
    [ApiController]
    public class TempController : ControllerBase {

        private readonly TempModelDbContext _context;

        public TempController(TempModelDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        public IActionResult Index()
        {

            _context.Temps.Add(null);
            _context.SaveChanges();
            return Ok();
        }
    }
}