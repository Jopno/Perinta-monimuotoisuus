using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShelfApplication
{
    class Tablets : Phone
    {
        public int Weight { get; set; }
        public Tablets(string model, string os, string color, int weight)
            : base(model, os, color)
        {
            Weight = weight;
        }
        public override string ToString()
        {
            return base.ToString() + "Weight: " + Weight;
        }

    }
}
