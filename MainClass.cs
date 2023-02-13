
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using assignment_1;

namespace assignment_1
{
    internal class Prime_2 : Appliance
    {
        public class MainClass
        {
            static List<Appliance> appliances = new List<Appliance>();




            static void Main(string[] args)
            {
                LoadApplianceListFile();
                Menu();

                Console.ReadKey();
            }

            static void LoadApplianceListFile()
            {
                string path = "C:\\VS C++ Codes\\Projects\\assignment 1\\appliances.txt";
                string[] lines = File.ReadAllLines(path);
                foreach (string line in lines)
                {
                    string[] fields = line.Split(';');
                    string l = fields[0];
                    char firstchar = l[0];
                    switch (firstchar)
                    {


                        case '0':

                            Vaccum v = new Vaccum();
                            v.ItemNumber = long.Parse(fields[0]);
                            v.Brand = fields[1];
                            v.Quantity = int.Parse(fields[2]);
                            v.Wattage = double.Parse(fields[3]);
                            v.Color = fields[4];
                            v.Price = double.Parse(fields[5]);
                            v.Grade = fields[6];
                            v.BatteryVoltage = double.Parse(fields[7]);
                            appliances.Add(v);
                            break;


                        case '1':
                            Microwaves m = new Microwaves();
                            m.ItemNumber = long.Parse(fields[0]);
                            m.Brand = fields[1];
                            m.Quantity = int.Parse(fields[2]);
                            m.Wattage = double.Parse(fields[3]);
                            m.Color = fields[4];
                            m.Price = double.Parse(fields[5]);
                            m.Capacity = double.Parse(fields[6]);
                            m.RoomType = fields[7];
                            appliances.Add(m);
                            break;

                        case '2':
                            Dishwasher d = new Dishwasher();
                            d.ItemNumber= long.Parse(fields[0]);
                            d.Brand = fields[1];
                            d.Quantity = int.Parse(fields[2]);
                            d.Wattage = (int)double.Parse(fields[3]);
                            d.Color = fields[4];
                            d.Price = (int)double.Parse(fields[5]);
                            d.SoundRating = fields[6];
                            d.Feature = fields[7];
                            break;
                        case '3':
                            Refrigerator r = new Refrigerator();
                            r.ItemNumber = int.Parse(fields[0]);
                            r.Brand = fields[1];
                            r.Quantity = int.Parse(fields[2]);
                            r.Wattage = (int)double.Parse(fields[3]);
                            r.Color = fields[4];
                            r.Price = (int)double.Parse(fields[5]);
                            r.NumberOfDoors = int.Parse(fields[6]);
                            r.Height = int.Parse(fields[7]);
                            r.Width = int.Parse(fields[8]);
                            break;
                    }


                }

            }
            static void Menu()
            {
                Console.Write("Welcome to Morden Appliances! r\n How may we assist you? r\n 1- Check out appliance r\n 2 - Find appliances by brand r\n 3 - Display appliances by brand r\n 4- Produce random appliance list r\n 5 Save and Exit ");
                string userInput = Console.ReadLine();
                if (userInput == "1")
                {
                    Checkout();

                }
                else if (userInput == "2")
                {

                }
            }
            static void Checkout()
            {
                Console.WriteLine("Enter the item number of an appliance");
                string userItemNumber = Console.ReadLine();
                long l = long.Parse(userItemNumber);
                foreach (Appliance appliance in appliances)

                {
                    if (appliance.ItemNumber== l)
                    {
                        if (appliance.Quantity > 0)
                        {
                            Console.WriteLine("Appliance" + userItemNumber + "has been checked out.");
                        }
                        if (appliance.Quantity < 0)
                        {
                            Console.WriteLine("Appliance" + userItemNumber + "Is not available to be check out.");
                        }
                        else
                        {
                            Console.WriteLine("No appliances found with that item number");
                        }
                        break;
                    }

                }
            }
            static void Find()
            {
                Console.WriteLine("Enter brand to search for:");
                string brand = Console.ReadLine();
                List<Appliance> found = new List<Appliance>();

                foreach (var appliance in appliances)
                {
                    if (appliance.Brand.Equals(brand, StringComparison.OrdinalIgnoreCase))
                    {
                        found.Add(appliance);
                    }
                }

            }
        }
    }
}
