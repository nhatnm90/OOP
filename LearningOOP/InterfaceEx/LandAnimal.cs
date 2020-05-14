using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceEx
{
    public class LandAnimal : Animal
    {
        public LandAnimal() { }
        public LandAnimal(string name) : base(name) { }
        public int NumberOfLegs { get; set; }

        public override void Showinfo()
        {
            Console.WriteLine(string.Format("The frog was named {0} is jumping with {1} legs", Name, NumberOfLegs));
        }
    }
}
