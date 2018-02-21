using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShelfApplication
{
    class Clothes
    {
        public char Size { get; set; }
        public string Color { get; set; }
        public string  Brand { get; set; }

        public Clothes(char size, string color, string brand)
        {
            Size = size;
            Color = color;
            Brand = brand;
        }

        public override string ToString()
        {
            return "Size: " + Size + "Color: " + Color + "Brand: " + Brand;
        }
    }
}
