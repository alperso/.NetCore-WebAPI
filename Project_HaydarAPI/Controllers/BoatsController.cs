using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Project_HaydarAPI.Controllers
{
    [Route("boats/")]
    [ApiController]
    public class BoatsController : ControllerBase
    {
        //Y Repo
        public static List<Boats> boatsvehicle = new List<Boats>()
        {
            new Boats{BoatsID=1,VehicleColor="white", VehicleMarka = "BOATSMARKA",VehicleName="Bot",VehicleTur="Boats"},
            new Boats{BoatsID=2,VehicleColor="red", VehicleMarka = "BOATSMARKA2",VehicleName="Bot",VehicleTur="Boats"},


        };
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(boatsvehicle.FindAll(x => x.VehicleTur == "Boats"));
            //return Ok(VehicleRepo.allvehicle.FindAll(x => x.VehicleTur == "Boats"));
        }

        [HttpGet("{color}")]
        public IActionResult GetByColor(string color)
        {

            //var results = boatsvehicle.FindAll(x => x.VehicleColor == color);
            var results = boatsvehicle.FindAll(x => x.VehicleColor == color);         
            var result2 = results.FindAll(x => x.VehicleTur == "Boats");
            //return Ok($"İd okundu#{id}.");
            return Ok(result2);
        }

    }
}
