using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceEx
{
    public abstract class Animal
    {
        public Animal() { }
        public Animal(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public abstract void Showinfo();
    }
}
