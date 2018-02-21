using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShelfApplication
{
    class Shirt : Clothes
    {
        public string Style { get; set; }

        public Shirt(char size, string color, string brand, string style) : base (size, color, brand)
        {
            Style = style;
        }
        public override string ToString()
        {
            return base.ToString() + "Style:" + Style;
        }
    }
}
