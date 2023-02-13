
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using assignment_1;

namespace assignment_1
{
    internal class Microwaves : Appliance
    {
    
        private long itemNumber;
        private string brand;
        private int quantity;
        private double wattage;
        private string color;
        private double price;
        private double capacity;
        private string roomType;

        public double Capacity { get => capacity; set => capacity = value; }
        public string RoomType { get => roomType; set => roomType = value; }

        public Microwaves()
        {

        }
        public Microwaves(long itemNumber, string brand, int quantity, double wattage, string color, double price, double capacity, string roomType)
        {
            this.ItemNumber = itemNumber;
            this.Brand = brand;
            this.Quantity = quantity;
            this.Wattage = (int)wattage;
            this.Color = color;
            this.Price = (int)price;
            this.Capacity = capacity;
            this.RoomType = roomType;
        }

        public override string ToString()
        {
            return "ItemNumber:" + itemNumber + "Brand:" + brand + "Quantity:" + quantity + "Wattage:" + wattage + "Color:" + color + "Price:" + price + "Capacity:" + capacity + "Room Type:" + roomType;
        }







    }



}