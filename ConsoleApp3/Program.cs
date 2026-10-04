using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TwoWheelerVehicle t1 = new TwoWheelerVehicle("125", "honda", "100000", "red", "petrol");
            t1.Display();

            TwoWheelerVehicle t2 = (TwoWheelerVehicle)t1.Clone();
            t2.engine = "250";
            t2.Display();

            FourWheeler f1 = new FourWheeler("1000", "Audi", "1200000", "blue", "auto");
            f1.Display();

            FourWheeler f2 = (FourWheeler)f1.Clone();
            f2.color = "red";
            f2.Display();

            FourWheeler f3 = (FourWheeler)f1.Clone();
            f3.engine = "1800";
            f3.Display();

            FourWheeler f4 = new FourWheeler("1800", "Audi", "1200000", "blue", "manual");
        }
    }
}
