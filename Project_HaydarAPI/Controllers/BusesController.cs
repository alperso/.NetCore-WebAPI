using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Project_HaydarAPI.Controllers
{
    [Route("buses/")]
    [ApiController]
    public class BusesController : ControllerBase
    {
        //Y Repo
        public static List<Buses> busesvehicle = new List<Buses>()
        {
            new Buses {BusesID=1,VehicleColor="blue", VehicleMarka = "OTOSAN",VehicleName="Otobüs",VehicleTur="Buses"},
            new Buses {BusesID=2,VehicleColor="black", VehicleMarka = "OTOSAN2",VehicleName="Otobüs",VehicleTur="Buses"},

        };
        //NOTE!!!!!!
        //İSTERSEK INTERFACE İLE METOTLARI OLUŞTURABİLİRİZ


        [HttpGet]
        public IActionResult Get()
        {
            return Ok(busesvehicle.FindAll(x => x.VehicleTur == "Buses"));
            //return Ok(VehicleRepo.allvehicle.FindAll(x => x.VehicleTur == "Buses"));
        }

        [HttpGet("{color}")]
        public IActionResult GetByColor(string color)
        {

            var results = busesvehicle.FindAll(x => x.VehicleColor == color);//Renge göre repodan arıyorum istersek IF ile control edilir
            var result2 = results.FindAll(x => x.VehicleTur == "Buses");//Gelen renk degerinden buses içindekileri çekiyorum

            //return Ok($"İd okundu#{id}.");
            return Ok(result2);
        }

    }
}
