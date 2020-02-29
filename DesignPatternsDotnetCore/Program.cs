using System;
using Shared;
using AbstractFactory;
using Builder;
using FactoryMethod;
using Prototype;
using Singleton;

namespace DesignPatternsDotnetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which design pattern do you want to execute?");
            string dp = Console.ReadLine();

            switch (dp)
            {
                case "Abstract Factory":
                    AbstractFactory();
                    break;
                case "Builder":
                    Builder();
                    break;
                case "Factory Method":
                    FactoryMethod();
                    break;
                case "Prototype":
                    Prototype();
                    break;
                case "Singleton":
                    Singleton();
                    break;
            }       
        }

        private static void AbstractFactory()
        // (Creational) Provide an interface for creating families of related or dependent objects without specifying their concrete classes.
        {
            Console.WriteLine("Do you want to make a \"car\" or \"van\"?");
            string input = Console.ReadLine();

            AbstractVehicleFactory factory = null;

            if (input == "car")
                factory = new AbstractFactory.CarFactory();
            else if (input == "van")
                factory = new AbstractFactory.VanFactory();
            
            if (factory == null)
                Console.WriteLine("Input not recognized.  Not making anything.  Press any key to exit program.");
            else
            {
                IBody body = factory.CreateBody();
                IChassis chassis = factory.CreateChassis();
                IGlassware glassware = factory.CreateGlassware();

                Console.WriteLine(body.BodyParts);
                Console.WriteLine(chassis.ChassisParts);
                Console.WriteLine(glassware.GlasswareParts);

                Console.WriteLine();
                Console.WriteLine("Press any key to exit program.");
            }

            Console.Read();
        }

        private static void Builder()
        // (Creational) Separate the creation of a complex object from its representation so that the same construction process can create different representations.
        {
            Shared.AbstractCar car = new Shared.Sedan(new Shared.StandardEngine(357));
            VehicleBuilder builder = new CarBuilder(car);
            VehicleDirector director = new CarDirector();
            Shared.IVehicle vehicle = director.Build(builder);
            Console.WriteLine(vehicle);
            Console.Read();
        }

        private static void FactoryMethod()
        // (Creational) Define an interface for creating an object, but let subclasses decide which class to instantiate.
        {
            VehicleFactory carFactory = new FactoryMethod.CarFactory();
            Shared.IVehicle car = carFactory.Build(VehicleFactory.DrivingStyle.Economical, VehicleColor.Blue);
            Console.WriteLine(car);

            VehicleFactory vanFactory = new FactoryMethod.VanFactory();
            Shared.IVehicle van = vanFactory.Build(VehicleFactory.DrivingStyle.Powerful, VehicleColor.White);
            Console.WriteLine(van);

            Shared.IVehicle sporty = VehicleFactory.Make(VehicleFactory.Category.Car, VehicleFactory.DrivingStyle.Powerful, VehicleColor.Red);
            Console.WriteLine(sporty);
        }
    
        private static void Prototype()
        // (Creational) Specify the kinds of objects to create using a prototypical instance, and create new objects by copying the prototype.
        {
            VehicleManager manager = new VehicleManager();

            Prototype.IVehicle sedan1 = manager.CreateSedan();
            Prototype.IVehicle sedan2 = manager.CreateSedan();
            Prototype.IVehicle pickup1 = manager.CreatePickup();

            Console.WriteLine(sedan1);
            Console.WriteLine(sedan2);
            Console.WriteLine(pickup1);

            VehicleManagerLazy lazyLoadManager = new VehicleManagerLazy();

            Prototype.IVehicle sedan3 = manager.CreateSedan();
            Prototype.IVehicle sedan4 = manager.CreateSedan();
            Prototype.IVehicle pickup2 = manager.CreatePickup();

            Console.WriteLine(sedan3);
            Console.WriteLine(sedan4);
            Console.WriteLine(pickup2);

        }
    
        private static void Singleton()
        // (Creational) Ensure a class allows only one object to be created, providing a single point of access to it.
        {
            Console.WriteLine("Next serial: " + SerialNumberGenerator.Instance.NextSerial);
            Console.WriteLine("Next serial: " + SerialNumberGenerator.Instance.NextSerial);
            Console.WriteLine("Next serial: " + SerialNumberGenerator.Instance.NextSerial);
            Console.WriteLine("Next serial: " + SerialNumberGenerator.Instance.NextSerial);
            Console.WriteLine("Next serial: " + SerialNumberGenerator.Instance.NextSerial);
        }
    }
}
