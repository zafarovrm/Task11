using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
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
                    Console.WriteLine("Нет решений, k не может быть равен 0");
                }
            }
        }
        static LinearEquation Equat(double k, double b)
        {
            LinearEquation eq = new LinearEquation(k, b);
            return eq;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение k");
            double k = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение b");
            double b = double.Parse(Console.ReadLine());            
            Equat(k, b).Root();            
            Console.ReadKey();
        }
    }
}
