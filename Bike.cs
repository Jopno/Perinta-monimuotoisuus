using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApplication
{
    class Bike : Vehicle
    {
        public bool GearWheels;
        public string GearName;

        public bool gearWheels
        {
            get
            {
                return GearWheels;
            }
            set
            {
                if (true)
                {
                    Console.WriteLine(GearName);
                }
            }

        }
        public Bike()
        {

        }
        public Bike(string name, string model, int modelYear, string color, bool gearWheels
          ,string gearName ) : base (name, model, modelYear, color)
        {
            GearName = gearName;
            GearWheels = gearWheels;
        }

        public override string ToString()
        {
            return "Bike:  \n" + base.ToString() + "GearWheels: " + GearWheels + "GearName: " + GearName;
        }
    }
}
