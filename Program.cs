using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_while_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Userchoice = "";
            do
            {
                int count = 0;
                int start = 0;
                Console.WriteLine("Enter Your Target");
                int Usertarget = int.Parse(Console.ReadLine());
                while (start <= Usertarget)
                {
                    Console.WriteLine(start + "");
                    start = start + 2;
                    count++;

                }
                Console.WriteLine("count= {0}", count);
                do
                {
                    Console.WriteLine("do you want to continue yes or no");
                    Userchoice = Console.ReadLine().ToUpper();
                    if (Userchoice != "YES" && Userchoice != "NO")
                    {
                        Console.WriteLine("Userchoice Invalid Please enter Yes or No");
                    }
                } while (Userchoice != "YES" && Userchoice != "NO");
            } while (Userchoice == "YES");
        }
    }
}
