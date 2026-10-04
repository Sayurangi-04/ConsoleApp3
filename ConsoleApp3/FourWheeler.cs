using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class FourWheeler : VehiclePrototype
    {
        public string transmission;
        public FourWheelerVehicle(string engine, string model, string price, string color, string transmission) : base(engine, model, price, color, transmission)
        {
            this.transmission = transmission;
        }

        public override VehiclePrototype Clone()
        {
            return new FourWheelVehicle(engine, model, price, color, transmission);
        }

        public override void Display()
        {
            Console.WriteLine($"FourWheelerVehicle")
        }
    }
}
