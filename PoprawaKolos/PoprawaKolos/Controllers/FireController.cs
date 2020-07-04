using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PoprawaKolos.DTO;
using PoprawaKolos.Models;

namespace PoprawaKolos.Controllers
{
    [Route("api/")]
    [ApiController]
    public class FireController : ControllerBase
    {


        private readonly FireDbContext _context;

        public FireController(FireDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        [Route("firefighters/{id}/actions")]
        public IActionResult ListAction(int id)
        {

            var list = _context.Firefighters.Where(fighters => fighters.IdFirefighter == id).First().Actions.Select(act => new
            {
                act.IdAction,
                act.StartTime,
                act.EndTime
            });


            return Ok(list);
        }


        [HttpPost]
        [Route("actiopns/1/fire-truks")]
        public IActionResult ActionTruck(fireActionTrack truck)
        {

            var lista = _context.Actions.Where(a => a.EndTime > DateTime.Now).Select(x => x.IdAction);

            int sumaAktywnosci = _context.FireTruck_Actions.Where(a => lista.Contains(a.IdAction) && a.IdFireTruck == truck.idFireTruck).Count();

            if(sumaAktywnosci > 0)
            {
                return BadRequest("Samochód w użyciu");
            }


            FireTruck tmp = _context.FireTrucks.Where(a => a.IdFireTruck == truck.idFireTruck).First();
            Models.Action act = _context.Actions.Where(a => a.IdAction == truck.idAction).First();

            act.FireTruck_Actions.Add(new FireTruck_Action { AssigmentDate = DateTime.Now, IdFireTruck = truck.idFireTruck, FireTruck = tmp, IdAction = act.IdAction, Action = act });

            _context.SaveChanges();


            return Ok("Samochód dodany do akcji");
        }
    }
}