using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Project_HaydarAPI.Controllers
{
    [Route("allvehicle/")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            //return Ok(VehicleRepo.allvehicle.FindAll(x=>x.VehicleTur=="Car"));
       
            //List Birleştirme işlemi
            var allProducts = new List<Object>(CarsController.carvehicle.Count +
                                    BusesController.busesvehicle.Count +
                                    BoatsController.boatsvehicle.Count);
            allProducts.AddRange(CarsController.carvehicle);
            allProducts.AddRange(BusesController.busesvehicle);
            allProducts.AddRange(BoatsController.boatsvehicle);
            return Ok(allProducts );
        }
    }
}
