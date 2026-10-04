using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Circle : ShapePrototype
    {
        public string color;
        public int size;

        public Circle(string clr,int size)
        {
            this.color = clr;
            this.size = size;
        }

        public ShapePrototype Clone()
        {
            return new Circle(this.color,this.size);
        }


        public void Draw()
        {
            Console.WriteLine("Drawing a " + this.color + " " + this.size+ " circle");
        }
    }
}
