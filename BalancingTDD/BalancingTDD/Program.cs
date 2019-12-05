using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancingTDD
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Mundo!");
            
            Console.ReadKey();

        }

        public static bool CheckParentesis(string input)
        {
            bool ret = false;
            bool foundOpen = false;
            bool foundClose = false;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Equals('('))
                {
                    foundOpen = true;
                }
                if (input[i].Equals(')'))
                {
                    if (foundOpen)
                    {
                        foundClose = true;
                    }
                }
            }

            if (foundOpen || foundClose)
            {
                ret = false;
            }

            if (foundClose && foundOpen)
            {
                ret = true;
            }
            return ret;
        }
        

    }
}
