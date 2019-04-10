using System;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building FiveOneTwoEigth = new Building("512 8th Avenue")
            {
                Width = 30,
                Depth = 41,
                Stories = 9,
            };

            FiveOneTwoEigth.Construct();
            FiveOneTwoEigth.Purchase("Bob Ross");
             Console.WriteLine(FiveOneTwoEigth);

            Building NSS = new Building("500 Interstate Blvd")
            {
                Width = 37,
                Depth = 46,
                Stories = 12,
            };

            NSS.Construct();
            NSS.Purchase("Bob Sagett");
            Console.WriteLine(NSS);

            Building Bridgestone = new Building("342 Broadway")
            {
                Width = 32,
                Depth = 23,
                Stories = 4,
            };

            Bridgestone.Construct();
            Bridgestone.Purchase("Bob Jones");

            Console.WriteLine(Bridgestone);
            
            City BobVille = new City();

            BobVille.addBuilding(FiveOneTwoEigth);
            BobVille.addBuilding(NSS);
            BobVille.addBuilding(Bridgestone);
            
            Console.WriteLine($"{BobVille.CityName} was established in {BobVille.EstablishedYear}. It has a maximum capacity of {BobVille.MaximumCapacity}");
         


            foreach (Building building in BobVille.ListOfBuildings)
            {
                Console.WriteLine(building.Designer);
                 Console.WriteLine(building.Address);

            }
        }
    }
}

