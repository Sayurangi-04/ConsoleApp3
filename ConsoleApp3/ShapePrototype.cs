using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public interface ShapePrototype
    {
        ShapePrototype Clone();
        void Draw();
    }
}
