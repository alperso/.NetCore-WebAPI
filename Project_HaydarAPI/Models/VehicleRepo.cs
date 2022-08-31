using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_HaydarAPI
{
    public class VehicleRepo
    {
        //Vehicle 
        public static List<Vehicle> allvehicle = new List<Vehicle>()
        {
            new Buses {BusesID=1,VehicleColor="blue", VehicleMarka = "OTOSAN",VehicleName="Otobüs",VehicleTur="Buses"},
            new Buses {BusesID=2,VehicleColor="black", VehicleMarka = "OTOSAN2",VehicleName="Otobüs",VehicleTur="Buses"},
            new Boats{BoatsID=1,VehicleColor="white", VehicleMarka = "BOATSMARKA",VehicleName="Bot",VehicleTur="Boats"},
            new Boats{BoatsID=2,VehicleColor="red", VehicleMarka = "BOATSMARKA2",VehicleName="Bot",VehicleTur="Boats"},
            new Car { CarID =1, VehicleColor="red", VehicleMarka = "FORD", VehicleTur="Car", Headlights="Far Kapalı",  Wheels=2 , VehicleName="Scooter"},
            new Car { CarID =2, VehicleColor="blue", VehicleMarka = "BMW", VehicleTur="Car", Headlights="Far Kapalı",  Wheels=4 , VehicleName="Binek"},
            new Car { CarID =3, VehicleColor="white", VehicleMarka = "BMW", VehicleTur="Car", Headlights="Far Kapalı",  Wheels=4 , VehicleName="Binek"}
            //new Car { CarID =3, VehicleColor="Red", VehicleMarka = "AUDİ", VehicleTur="Car", Headlights="Far Kapalı",  Wheels=8 , VehicleName="Tır"},
            //new Car { CarID =4, VehicleColor="Red", VehicleMarka = "TOFAŞ", VehicleTur="Car", Headlights="Far Kapalı",  Wheels=4 , VehicleName="Binek"},
            //new Car { CarID =5, VehicleColor="Red", VehicleMarka = "AUDİ", VehicleTur="Car", Headlights="Far Kapalı",  Wheels=4 , VehicleName="Binek"}
        
        };

}
}
