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
            int countOpen = 0;
            bool foundClose = false;
            int countClose = 0;
            int foundCounting = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Equals('('))
                {
                    foundOpen = true;
                    countOpen++;
                }
                if (input[i].Equals(')'))
                {
                    countClose++;
                    if (foundOpen)
                    {
                        foundClose = true;
                        foundCounting++;
                        foundOpen = false;
                    }
                }
            }

            if (foundOpen || foundClose)
            {
                ret = false;
            }

            if (foundClose && foundOpen )
            {
                ret = true;
            }

            if (foundCounting > 0 && countOpen.Equals(countClose))
            {
                ret = true;
            }
            return ret;
        }
        

    }
}
