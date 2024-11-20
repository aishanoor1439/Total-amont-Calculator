using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Total_amont_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double totalAmount = 0;
            double price = 0;

            //Initialization
            int i = 1;

            //Condition
            while (true)
            {
                Console.WriteLine("Enter price of item {0} or enter a negative number to stop:", i);
                price = Convert.ToDouble(Console.ReadLine());
                
                //Break the loop on negative value
                if (price < 0)
                {
                    break;
                }

                totalAmount += price;

                //Incrementation
                i++;
            }
            Console.WriteLine("Total amount: {0}", totalAmount);
        }
    }
}
