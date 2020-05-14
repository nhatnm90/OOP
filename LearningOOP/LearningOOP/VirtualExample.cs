using System;
using System.Collections.Generic;
using System.Text;

namespace LearningOOP
{
    public class VirtualExample
    {
        public class Animal
        {
            public Animal() { }
            public Animal(string name)
            {
                Name = name;
            }

            public string Name { get; set; }

            public virtual void SayHello()
            {
                Console.WriteLine("Animal hello: abc");
            }
        }

        public class Dog : Animal
        {
            public Dog(string dogName) : base(dogName)
            {
            }

            public override void SayHello()
            {
                Console.WriteLine(string.Format("Dog was named {0} says hello: go go go", this.Name));
            }

            protected void Bark()
            { }
        }
    }
}
