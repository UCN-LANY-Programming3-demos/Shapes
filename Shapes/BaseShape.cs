using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal abstract class BaseShape // Marked abstract so it can not be instantiated
    {
        // virtual methods offers implementation, but can be overridden in derived classes
        //public virtual void Draw()
        //{
        //    Console.WriteLine("drawing shape");
        //}

        // abstract methods forces derived classes to implement them
        public abstract void Draw();

        public int CalculateArea()
        {
            Console.WriteLine("Base class");
            return 0;
        }
    }
}
