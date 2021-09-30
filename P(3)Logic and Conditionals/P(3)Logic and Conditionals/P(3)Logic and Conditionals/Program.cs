using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_3_Logic_and_Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            bool beach = true;
            bool hiking = false;
            bool city = true;

            bool yourNeeds = (beach && city);
            bool friendNeeds = (beach || hiking);

            bool tripDecision = (yourNeeds && friendNeeds);
            Console.WriteLine(tripDecision);

        }
        static void Conditionals()
        {
            double pepperLength = 4;

            string message = (pepperLength >= 3.5) ? "ready!" : "wait a little longer";

            Console.WriteLine(message);
        }
    }
}
