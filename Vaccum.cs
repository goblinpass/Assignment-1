using assignment_1;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_1
{
    internal class Vaccum : Appliance
    {

        private string grade;
        private double batteryVoltage;

        public Vaccum()
        {

        }

        public Vaccum(long itemNumber, string brand, int quantity, double wattage, string color, double price, string grade, double batteryVoltage)
        {
            this.ItemNumber = itemNumber;
            this.Brand = brand;
            this.Quantity = quantity;
            this.Wattage = (int)wattage;
            this.Color = color;
            this.Price = (int)price;
            this.Grade = grade;
            this.BatteryVoltage = batteryVoltage;
        }


        public string Grade { get => grade; set => grade = value; }
        public double BatteryVoltage { get => batteryVoltage; set => batteryVoltage = value; }

        
    }
}

