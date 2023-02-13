using assignment_1;

namespace assignment_1
{
    internal class Refrigerator : Appliance
    {
        private int numberOfDoors;
        private int height;
        private int width;

        public int NumberOfDoors { get => NumberOfDoors; set => NumberOfDoors = value; }
        public int Height { get => Height; set => Height = value; }
        public int Width { get => Width; set => Width = value; }


        public Refrigerator(long itemNumber, string brand, int quantity, int wattage, string color, int price, int numberOfDoors, int height, int width)
        {
            this.ItemNumber = itemNumber;
            this.Brand = brand;
            this.Quantity = quantity;
            this.Wattage = wattage;
            this.Color = color;
            this.Price = price;
            this.NumberOfDoors = numberOfDoors;
            this.Height = height;
            this.Width = width;
        }

        public Refrigerator()
        { }



    }
}
