using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShelfApplication
{
    class Phone
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public string Os { get; set; }

        public Phone (string model, string color, string os)
        {
            Model = model;
            Color = color;
            Os = os;
        }

        public override string ToString()
        {
            return "Model:" + Model + "Color:" + Color + "Os:" + Os;
        }
    }
}
