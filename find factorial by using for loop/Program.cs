using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace find_factorial_by_using_for_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = 5;
            int Fact = 1;
            for (int i = 1; i <= N; i++) 
            {
                Fact = Fact * i;
                
            }
            Console.WriteLine(Fact);


        }
    }
}
