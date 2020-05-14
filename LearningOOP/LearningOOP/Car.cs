using System;
using System.Collections.Generic;
using System.Text;

namespace LearningOOP
{
    abstract class Car
    {
        #region Properties
        public string Name { get; set; }
        public int Year { get; set; }

        public List<string> CarByType { get; set; }

        double price;
        public double Price
        {
            get { return price; }
            set
            {
                if (value > 0)
                {
                    price = value;
                    IsLuxury = value > 5000;
                }
                else
                {
                    price = 0;
                }
            }
        }

        public bool IsLuxury { get; set; }


        #endregion

        #region Constructor
        public Car() {
            Name = "Car name was set by constructor";
        }

        public Car(string name)
        {
            Name = string.Format("base case - {0}", name);
        }

        public Car(string name, double price)
        {
            Name = name;
            Price = price;
        }

        private int numberOfWheels;
        public int NumberOfWheels {
            get
            {
                return numberOfWheels;
            }
            set
            {
                numberOfWheels = value;
            }
        }
        #endregion

        public void DisplayInfo()
        {
            Console.WriteLine("-----------CAR INFORMATION OF BASE----------------");
            Console.WriteLine(string.Format("Name: {0}", Name));
            Console.WriteLine(string.Format("Price: {0}", Price));
            Console.WriteLine(string.Format("{0} is a {1} car", Name, IsLuxury ? "LUXURY" : "non-luxury"));
        }

        public abstract void Run();
    }

    class FamilyCar : Car, ICarResponsibility
    {
        public FamilyCar()
        {
            NumberOfWheels = 4;
        }

        public FamilyCar(string carName) : base(carName)
        {
            Name = string.Format("derived class {0}", carName);
        }

        public int TestProps { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void DisplayCarInfo()
        {
            Run();
            string[] cars = { "Kona", "Tucson", "Santafe" };
            Console.WriteLine(cars.ToString());
        }

        public new void DisplayInfo()
        {
            Utils.ShowNewLine("+");
            base.DisplayInfo();
            Utils.ShowNewLine("#");
        }

        public override void Run()
        {
            Console.WriteLine("Family Car Run");
        }
    }

    class ConstructCar : Car
    {
        public ConstructCar()
        {
            NumberOfWheels = 16;
        }

        public ConstructCar(string carName)
        {
            Name = carName;
        }

        public override void Run()
        {
            Console.WriteLine("Construct Car Run");
        }
    }

    class TransportsCar : Car, ICarResponsibility
    {
        public TransportsCar()
        {
            NumberOfWheels = 10;
        }

        public void DisplayCarInfo()
        {
            throw new NotImplementedException();
        }

        public override void Run()
        {
            Console.WriteLine("Transports Car Run");
        }
    }
}
