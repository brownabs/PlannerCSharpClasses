using System;

namespace Planner
{
    class Building
    {
        //constructor method -- must be named the same as the class
        public Building(string address)
        {
            _Address = address;
        }

        //Public Methods
        //Define a Construct() method. The method's logic should set the _dateConstructed field's value to DateTime.Now.
        //Define a Purchase() method. The method should accept a single string argument of the name of the person purchasing a building
        //The method should take that string and assign it to the private _owner field.
        //any method that doesn't return anything is a void
        //get and set are logic to run when someone wants to get or set the value of the object
        public void Construct()
        {
            _DateConstructed = DateTime.Now;
        }

        public void Purchase(string purchaser)
        {
            _Owner = purchaser;
        }

        public string Address {
            get {return _Address;}
            set { _Address = value;}
        }

         public DateTime DateConstructed {
            get {return _DateConstructed;}
            set { _DateConstructed = value;}
        }

          public string Owner {
            get {return _Owner;}
            set { _Owner = value;}
        }
        private string _Designer = "Abbey Brown";
        private DateTime _DateConstructed; 
        private string _Address;
        private string _Owner;
        public int Stories { get; set; } // get and set like this -- there are no restrictions
        public double Width { get; set; }
        public double Depth { get; set; }
        public bool IsLocal { get; set; }

        public double Volume
        {
            get
            {
                return Width * Depth * (3 * Stories);
            }
        }

        public string Designer { get => _Designer; set => _Designer = value; }

        public override string ToString() {
            return $@"
{_Address}
___________________
Designed by {_Designer}
Constructed by {_DateConstructed}
Owned by {_Owner}
{Volume} cubic meters of space.";

        }
    }
}