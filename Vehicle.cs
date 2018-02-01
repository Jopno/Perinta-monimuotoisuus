using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApplication
{
    class Vehicle
    {
        public string Name;
        public string Model;
        public int ModelYear;
        public string Color;


        public Vehicle()
        {

        }

        public Vehicle (string name, string model, int modelYear, string color)
        {
            Name = name;
            Model = model;
            ModelYear = modelYear;
            Color = color;
        }

        public override string ToString()
        {
            return "Name: " + Name + " Model: " + Model + " ModelYear: " + ModelYear + " Color: " + Color;
        }



    }
}
