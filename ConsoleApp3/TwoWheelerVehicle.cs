using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class TwoWheelerVehicle : VehiclePrototype
    {
        public string fuel;

        public TwoWheelerVehicle(string engine, string model, string price, string color, string fuel) : base(engine, model, price, color)
        {
            this.fuel = fuel;
        }

        public override VehiclePrototype Clone()
        {
            return new TwoWheelerVehicle(engine, model, price, color, fuel);
        }

        public override void Display()
        {
            Console.WriteLine($"TwoWheeler {engine} {model} {price} {color} {fuel}");
        }
    }
}
