using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace Project_HaydarAPI.Controllers
{
    [Route("cars/")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        //[HttpGet]
        //public IEnumerable<string> Get()
        // {
        //    return new string[] { "Value 1", "Value2" };
        // }

        //        [HttpGet("{id}")]
        //        public string Get(int id)
        //        {
        //            return "Gelen deger"+id;
        //        }

        //        private static readonly string[] Summaries = new[]
        //{
        //            "Tofaş", "BMW", "FORD", "FIAT"
        //        };


        //        [HttpGet]
        //        public IEnumerable<Car> Get()
        //        {
        //            var rng = new Random();
        //            return Enumerable.Range(1, 5).Select(index => new Car
        //            {
        //                CarID = rng.Next(0, 55),
        //                VehicleColor="Red",
        //                VehicleMarka = Summaries[rng.Next(Summaries.Length)],
        //                VehicleTur="Car",
        //                VehicleName="Name",
        //                Wheels= rng.Next(2, 8),
        //                Headlights="Far Kapalı"

        //                //Date = DateTime.Now.AddDays(index),
        //                //TemperatureC = rng.Next(-20, 55),

        //            })
        //            .ToArray();
        //        }

        //private readonly ILogger<ValuesController> _logger;

        //public ValuesController(ILogger<ValuesController> logger)
        //{
        //    _logger = logger;
        //}
        //public static List<Car> caars = new List<Car>()
        //{
        //    //new Buses {BusesID=1,VehicleColor="Blue",VehicleName="Otobüs",VehicleTur="Buses"},
        //    //new Buses {BusesID=2,VehicleColor="Blue",VehicleName="Otobüs",VehicleTur="Buses"},
        //    //new Boats{BoatsID=1,VehicleColor="Black",VehicleName="Bot",VehicleTur="Boats"},
        //    //new Boats{BoatsID=2,VehicleColor="Black",VehicleName="Bot",VehicleTur="Boats"},
        //    new Car { CarID =1, VehicleColor="red", VehicleMarka = "FORD", VehicleTur="Car", Headlights="Far Kapalı",  Wheels=2 , VehicleName="Scooter"},
        //    new Car { CarID =2, VehicleColor="black", VehicleMarka = "BMW", VehicleTur="Car", Headlights="Far Kapalı",  Wheels=4 , VehicleName="Binek"},
        //    new Car { CarID =3, VehicleColor="white", VehicleMarka = "AUDİ", VehicleTur="Car", Headlights="Far Kapalı",  Wheels=8 , VehicleName="Tır"},
        //    new Car { CarID =4, VehicleColor="Blue", VehicleMarka = "TOFAŞ", VehicleTur="Car", Headlights="Far Kapalı",  Wheels=4 , VehicleName="Binek"},
        //    //new Car { CarID =5, VehicleColor="Red", VehicleMarka = "AUDİ", VehicleTur="Car", Headlights="Far Kapalı",  Wheels=4 , VehicleName="Binek"}
        //};


        //public static List<Car> GetAll() => caars;
        //public static void Add(Car car)
        //{
        //    //car.CarID = 5;
        //    caars.Add(car);

        //} 




        //[HttpGet]
        //public ActionResult<IEnumerable<Vehicle>> getAllBooks()
        //{
        //    return caars;
        //}

        public static List<Car> carvehicle = new List<Car>()
        {
            new Car { CarID =1, VehicleColor="red", VehicleMarka = "FORD", VehicleTur="Car", Headlights="Far Kapalı",  Wheels=2 , VehicleName="Scooter"},
            new Car { CarID =2, VehicleColor="blue", VehicleMarka = "BMW", VehicleTur="Car", Headlights="Far Kapalı",  Wheels=4 , VehicleName="Binek"},
            new Car { CarID =3, VehicleColor="white", VehicleMarka = "BMW", VehicleTur="Car", Headlights="Far Kapalı",  Wheels=4 , VehicleName="Binek"}
        };

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(carvehicle.FindAll(x=>x.VehicleTur=="Car"));
            //return Ok(carvehicle.FindAll(x => x.VehicleTur == "Car"));
        }

        [HttpGet("{color}")]
        public IActionResult GetByColor(string color)
        {
           // var results = carvehicle.FindAll(x => x.VehicleColor == color);
            var results = carvehicle.FindAll(x => x.VehicleColor == color);
            var result2 = results.FindAll(x => x.VehicleTur == "Car");

            //return Ok($"İd okundu#{id}.");
            return Ok(result2);
        }

        [HttpPost]
        [Route("/cars/onoff")]
        public IActionResult GetByCarIDChangeLight([FromBody] Car ncar)
        {
       
     
            var results = carvehicle.FindAll(x => x.CarID == ncar.CarID);
            if (results.Count > 0)
            {
                foreach (var mc in carvehicle.Where(x => x.CarID == ncar.CarID))
                {
                    mc.Headlights = ncar.Headlights;
                }
                return Ok(carvehicle);
            }
            return Ok("Böyle bir car yok");
        }
        [HttpDelete]
        [Route("/cars/delete")]
        public IActionResult GetByCarDelete([FromBody] Car ncar)
        {
            var results = carvehicle.FindAll(x => x.CarID == ncar.CarID);
            if (results.Count > 0)
            {
                var itemToRemove = carvehicle.Single(r => r.CarID == ncar.CarID);
                carvehicle.Remove(itemToRemove);
                return Ok(carvehicle);
            }
            return Ok("Böyle bir car yok");
        }


        //[HttpGet("{color}")]
        //public IActionResult GetByColor(string color)
        //{

        //    var results = caars.Where(x => x.VehicleColor == color).ToList();
        //    return Ok(results);
        //}


        //[HttpGet("{color}")]
        //public ActionResult<Car> GetSelectCarColor(string color)
        //{
        //    // var results = caars.FindAll(x => x.VehicleColor==color);
        //    //var boo = caars.FindAll(x => x.VehicleColor == color);



        //    var results = caars.Where(x => x.VehicleColor == color).FirstOrDefault();

        //    if (results == null)
        //    {
        //        return null;
        //    }

        //    return results;

        //}

        //[HttpPost("car/create")]
        //public ActionResult<Car> Post(Car car)
        //{
        //    // var results = caars.FindAll(x => x.VehicleColor==color);
        //    //var boo = caars.FindAll(x => x.VehicleColor == color);



        //    var results = caars.Where(x => x.VehicleColor == color).FirstOrDefault();

        //    if (results == null)
        //    {
        //        return null;
        //    }

        //    return results;

        //}
    }
}
