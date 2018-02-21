using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShelfApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone phone = new Phone("Honor8", "Black", "Android");
            Tablets tablet = new Tablets("Tablet PC", "White", "Android", 1);

            Clothes shorts = new Clothes('L', "Black", "Adidas");
            Clothes shirt = new Shirt('L', "Red", "Reebok", "T-Shirt");

            Console.WriteLine(phone.ToString());
            Console.WriteLine(tablet.ToString());
            Console.WriteLine(shorts.ToString());
            Console.WriteLine(shirt.ToString());

        }
    }
}
