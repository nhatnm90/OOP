using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceEx
{
    public class Frog : LandAnimal, ILandAnimal, IWaterAnimal
    {
        public int NumberOfColors { get; set; }
        public Frog()
        {
            NumberOfLegs = 4;
        }

        public Frog(string name) : base(name)
        {
            Name = name;
        }

        public Frog(int numberOfColors)
        {
            NumberOfColors = numberOfColors;
        }


        public void Move()
        {
            Console.WriteLine(string.Format("The frog was named {0} is jumping with {1} legs", Name, NumberOfLegs));
        }

        void IWaterAnimal.Move()
        {
            Console.WriteLine(string.Format("The frog was named {0} is swimming", Name));
        }

        public override void Showinfo()
        {
            Console.WriteLine(string.Format("Name: {0} - Color(s): {1}", Name, NumberOfColors));
        }
    }
}
