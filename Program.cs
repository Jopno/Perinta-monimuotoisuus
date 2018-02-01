using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Boat speedo = new Boat();
            speedo.Name = "Suvi";
            speedo.Model = "S900";
            speedo.ModelYear = 1990;
            speedo.Color = "White";
            speedo.SeatCount = 3;
            speedo.BoatType = "Rowboat";
            Console.WriteLine(speedo.ToString());

            Bike spurdo = new Bike();
           spurdo.Name = "Tunturi ";
            spurdo.Model = "StreetPower ";
            spurdo.ModelYear = 2003;
            spurdo.Color = "Black ";
            spurdo.GearWheels = false;
            spurdo.GearName = "MasterSpeedo ";

            Console.WriteLine(spurdo.ToString());


            Console.ReadLine();





        }
    }
}
