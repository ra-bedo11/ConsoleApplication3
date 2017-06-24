using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            ///https://github.com/ra-bedo11/C-Codes_1.git
            ///
            float mf = float.MinValue;
            float maxf = float.MaxValue;

            Console.WriteLine("float min val =  {0}, float max val = {1}", mf, maxf);
            Console.WriteLine("double min val = " + double.MinValue + " " + " double max val" + double.MaxValue);
            Console.WriteLine("decimal min val = " + decimal.MinValue + " " + " decimal max val" + decimal.MaxValue);

            float fvar = 1f / 3;
            double dvar = 1d / 3;
            decimal mvar = 1m / 3;
            Console.Write(" float = {0},\n double = {1},\n decimal = {2} \n", fvar, dvar, mvar);
        }
    }
}
