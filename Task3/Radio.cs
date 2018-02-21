using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioApplication
{
    class Radio
    {
        private int volume;
        private double channel;
        public bool Power { get; set; }

        public int Volume
        {
            get { return volume; }
            set
            {
                if (value < 0)
                {
                    volume = 0;
                }
                else if (value > 10)
                {
                    volume = 10;
                }
                else
                {
                    volume = value;
                }
            }
        }
        public double Channel
        {
            get { return channel; }
            set
            {
                if ( value > 2600.0)
                {
                    channel = 2600.0;
                }
                    else if (value < 2000.0)
                {
                    channel = 2000.0;
                }
                else
                {
                    channel = value;
                }
            }
        }
        public void PowerOn()
        {
            Power = true;
        }
        public void PowerOff()
        {
            Power = false;
        }
    }
}
