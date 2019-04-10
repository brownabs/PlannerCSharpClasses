using System;
using System.Collections.Generic;

namespace Planner
{
    class City 

    {
        
        public string CityName {
            get {return _CityName;}
        }

         public int MaximumCapacity {
            get {return _MaximumCapacity;}
        }

         public int EstablishedYear {
            get {return _EstablishedYear;}
        }
        private string _CityName = "BobVille";
        private int _MaximumCapacity = 1000000;
        private int _EstablishedYear = 1876; 

        public List<Building> ListOfBuildings {get; set;} = new List<Building>();

           public void addBuilding(Building building) 
        {
           ListOfBuildings.Add(building);
        }


    }

    }
