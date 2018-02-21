using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Radio radio = new Radio();
            radio.PowerOff();
            while (true)
            {
                Console.WriteLine("Change channel 0");
                Console.WriteLine("Change volume  1");
                Console.WriteLine("Power on  2");
                Console.WriteLine("Power off 3");
                Console.WriteLine("Quit 4");
                bool result = int.TryParse(Console.ReadLine(), out int number);
                if (result)
                    switch (number)
                    {
                        case 0:
                            {
                                Console.Write("Set channel 2000.0 - 26000.0: ");
                                bool result2 = double.TryParse(Console.ReadLine(), out double number2);
                                if (result2)
                                    radio.Channel = number2;
                                else
                                    continue;
                                continue;
                            }
                        case 1:
                            {
                                Console.Write("Set volume 1 - 10: ");
                                bool result2 = int.TryParse(Console.ReadLine(), out int number2);
                                if (result2)
                                    radio.Volume = number2;
                                else
                                    continue;
                                continue;
                            }
                        case 2:
                            {
                                Console.Write("Set power on? yes/no: ");
                                string input = Console.ReadLine();
                                if (input == "yes")
                                    radio.PowerOn();
                                else
                                    continue;
                                continue;
                            }
                        case 3:
                            {
                                Console.Write("Set power off? yes/no: ");
                                string input = Console.ReadLine();
                                if (input == "yes")
                                    radio.PowerOff();
                                else
                                    continue;
                                continue;
                            }
                        case 4:
                            break;
                    }
                break;
            }
        }
    }
    
}
