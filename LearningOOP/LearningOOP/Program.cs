using System;
using static LearningOOP.VirtualExample;

namespace LearningOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //var kona = new Car();
            //kona.IsLuxury = true;
            //kona.Price = 10000;

            //kona.DisplayInfo();

            //var santafe = new Car("Hyundai SantaFE", 3000);

            //santafe.DisplayInfo();

            var car = new FamilyCar("nhat");
            car.DisplayInfo();

            Utils.ShowNewLine();

            var consCar = new ConstructCar("construct car");
            consCar.DisplayInfo();

            Utils.ShowNewLine("~");

            Car fCar = new FamilyCar();
            fCar.Run();

            Utils.ShowNewLine();

            Car cCar = new ConstructCar();
            cCar.Run();

            Utils.ShowNewLine("~");

            Animal an = new Animal();
            an.SayHello();

            Animal dog = new Dog("Yellow");
            dog.SayHello();

            Utils.ShowNewLine("~");

            var faCar = new FamilyCar();
            faCar.DisplayCarInfo();

            Console.ReadLine();

            var trCar = new TransportsCar();
            trCar.DisplayCarInfo();
        }
    }
}
