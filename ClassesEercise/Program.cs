using System;

namespace ClassesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Toyota toyota = new Toyota(150.00M, 6, 4);
            ElectricFlyingCar flyingCar = new ElectricFlyingCar(250.00M, 4,4);
            Boat boat = new Boat(200.00M, 2);
            Boeing boeing = new Boeing(200.00M, 200, 15000.00M);

            //Prit all data and call methods
            Console.WriteLine(toyota);
            toyota.Handle();
            //toyota.MaxSpeed = 12.00M;
            Console.WriteLine(flyingCar);
            flyingCar.Fly();
            flyingCar.Land();
            Console.WriteLine(boat);
            boat.Navigate();
            Console.WriteLine(boeing);
            boeing.Fly();
            boeing.Land();
        }
    }
    public class Transport
    {
        protected decimal MaxSpeed { get; set; }
        public int Capacity { get; set; }

        public override string ToString()
        {
            return $"{this.GetType().Name}\n Max Speed: {this.MaxSpeed}\n Capacity: {this.Capacity}\n";
        }

    }

    public interface IFly
    {
        public void Fly();
        public void Land();
    }
    public class AirTransport : Transport, IFly
    {
        public decimal MaximunHeight { get; set; }

        public void Fly()
        {
            Console.WriteLine($"> {this.GetType().Name} is flying.\n");
        }

        public void Land()
        {
            Console.WriteLine($"> {this.GetType().Name} is landing.\n");
        }
        public override string ToString()
        {
            return string.Concat(base.ToString(), $" Maximum Height: {this.MaximunHeight}\n") ;
        }
    }
    public class LandTransport : Transport
    {
        public int Wheels { get; set; }
        public void Handle()
        {
            Console.WriteLine($"{this.GetType().Name} is being handle.\n");
        }

        public override string ToString()
        {
            return string.Concat(base.ToString(), $" Wheels: {this.Wheels}\n") ;
        }
    }
    public class AquaticTransport : Transport
    {
        public void Navigate()
        {
            Console.WriteLine($"> {this.GetType().Name} is navigating.\n");
        }
    }

    public class Toyota : LandTransport
    {
        public Toyota(decimal maxVel, int capacity, int wheels)
        {
            base.MaxSpeed = maxVel;
            base.Capacity = capacity;
            base.Wheels = wheels;
        }
    }

    public class ElectricFlyingCar : LandTransport, IFly
    {

        public ElectricFlyingCar(decimal maxVel, int capacity, int wheels)
        {
            base.MaxSpeed = maxVel;
            base.Capacity = capacity;
            base.Wheels = wheels;
        }

        public void Fly()
        {
            Console.WriteLine($"> {this.GetType().Name} is flying.\n");
        }

        public void Land()
        {
            Console.WriteLine($"> {this.GetType().Name} is landing.\n");
        }
    }

    public class Boat: AquaticTransport
    {  
        public Boat(decimal maxVel, int capacity)
        {
            base.MaxSpeed = maxVel;
            base.Capacity = capacity;
        }
    }
    public class Boeing : AirTransport
    {
     
        public Boeing(decimal maxVel, int capacity, decimal maxHeight)
        {
            base.MaxSpeed = maxVel;
            base.Capacity = capacity;
            base.MaximunHeight = maxHeight;
        }
    }
}
