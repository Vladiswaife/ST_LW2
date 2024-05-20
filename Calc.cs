using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace CalcLib
{
    public class Calc
    {
        public int Sum(int x, int y) 
        {
            return x + y;
        }
        public int Diff(int x, int y)
        {
            return x - y;
        }
        public double Div(int x, int y)
        {
            return x/y;
        }
        public double Mul(int x, int y)
        {
            return x * y;
        }
        public double Pow_x_y(int x, int y)
        {
            return Math.Pow(x, y);
        }
        public double Sqrt_x(int x)
        {
            return Math.Sqrt(x);
        }
        public int Tringle(int x, int y)
        {
            return (x * y)/2;
        }
        public double Sale(int price, int sale)
        {
            return price/100 * (100-sale);
        }
        public double Round_s(double r)
        {
            return r*Math.PI*Math.PI;
        }
        public double Round_pl(double r)
        {
            return r * Math.PI *2;
        }

    }
}
