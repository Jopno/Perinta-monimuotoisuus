using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApplication
{
    class Boat : Vehicle
    {
        public int SeatCount { get; set; }
        public string BoatType { get; set; }

        public Boat()
        {

        }

        public Boat(string name, string model, int modelYear, string color, int seatCount 
            ,string boatType) : base (name, model, modelYear, color)
        {
            SeatCount = seatCount;
            BoatType = boatType;
        }

        public override string ToString()
        {
            return "Boat: \n" + base.ToString() + "SeatCount: " + SeatCount + " BoatType: " + BoatType;
        }
    }
}
