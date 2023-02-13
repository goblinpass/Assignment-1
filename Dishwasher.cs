using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_1
{

    internal class Dishwasher:Appliance
    {
        private string soundRating;
        private string feature;

        public Dishwasher(long itemNumber, string brand, int quantity, int wattage, string color, int price, string soundRating, string feature)
        {
            this.soundRating = soundRating;
            this.feature = feature;
        }

        public string SoundRating { get => soundRating; set => soundRating = value; }
        public string Feature { get => feature; set => feature = value; }

        public Dishwasher() { }
    }
}
