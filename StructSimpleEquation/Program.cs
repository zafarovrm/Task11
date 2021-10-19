using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructSimpleEquation
{
    class Program
    {
        public struct LinearEquation
        {
            public double k;
            public double b;
            public LinearEquation(double k, double b)
            {
                this.k = k;
                this.b = b;
            }
            public void Root()
            {
                double x = 0;
                if (this.k != 0)
                {
                    x = (-this.b / this.k);
                    Console.WriteLine("x={0}", x);
                }
                else
                {
                    if (this.b == 0)
                    {
                        Console.WriteLine("x={любое число }");
                    }
                    else { Console.WriteLine("x={ нет решения}"); }
                }
            }
        }
    }
}
