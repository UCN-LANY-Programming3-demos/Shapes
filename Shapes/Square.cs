using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Square : BaseShape
    {
        public override void Draw()
        {
            Console.WriteLine("drawing square");
        }

        public new int CalculateArea()
        {
            Console.WriteLine("derived class");
            return 0;
        }
    }
}
