using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepHydrated
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Litres(11.8));
        }



        public static int Litres(double time)
        {
            int a = (int)Math.Floor(time * 0.5);
            return a;
        }
    }
}
