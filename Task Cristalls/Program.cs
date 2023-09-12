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
            Console.WriteLine("Hello, adventurer! Today we have cristalls for " + cristallPrice + " gold. How much gold do you have?");
            userGold = Convert.ToInt32(Console.ReadLine());
            int cirstallSold = userGold / cristallPrice;
            int change = userGold % cristallPrice;
            Console.WriteLine("So, advanturer, now you have " + cirstallSold + " cristalls, and your change is " + change + " gold");
        }
    }
}
