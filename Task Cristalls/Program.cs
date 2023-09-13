using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Cristalls
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cristallPrice = 10;
            int userGold;
            int cristallToBuy;
            Console.WriteLine("Hello, adventurer! Today we have cristalls for " + cristallPrice + " gold. How much gold do you have?");
            userGold = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Excellent, adventurer! And how many cristalls do you want to buy?");
            cristallToBuy = Convert.ToInt32(Console.ReadLine());
            int shortChange = userGold - cristallToBuy * cristallPrice;
            Console.WriteLine("So, advanturer, here is your " + cristallToBuy + " cristalls, and your change is " + shortChange + " gold");
        }
    }
}
