using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    public class AirConditioner
    {
        public int Now_temperatur {
            get;
            set;
        }
        public int blowingIntensity { get; set; }
        public AirConditioner(int Now_temperatur, int blowingIntensity)
        {
            this.Now_temperatur = Now_temperatur;
            this.blowingIntensity = blowingIntensity;
        }
        public void Inc_temperature()
        {
            if (Now_temperatur < 30)
            {
                Now_temperatur++;

            }

        }
        public void Dec_temperature()
        {
            if (Now_temperatur > 30)
            {
                Now_temperatur--;
            }

        }
        public void Dec_blowingIntensity()
        {
            if (blowingIntensity == 10)
            {
                blowingIntensity = 1;
            }
            else
                blowingIntensity++;
        }
        public void Inc_blowingIntensity()
        {
            if (blowingIntensity == 1)
            {
                blowingIntensity = 10;
            }
            else
                blowingIntensity++;
        }
    }
}
