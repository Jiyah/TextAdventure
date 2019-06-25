using System;

namespace BirminghamTextAdventureProj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("Hello, " + name + ".");
            Console.WriteLine("Would you like to hear a joke?");
            string response = Console.ReadLine();
            if (response.ToLower() == "yes")
            {
                Console.WriteLine("Why do Java programmers wear glasses?");
                System.Threading.Thread.Sleep(2000);//2,000ms
                Console.WriteLine("Because they cant C#.");
                System.Threading.Thread.Sleep(1000);//1,000ms
                Console.WriteLine("HAHA get it? See Sharp!");
            }
            else
            {
                Console.WriteLine("Wow, who doesnt like a good laugh?");
            }

            Console.WriteLine("Would you like to hear another joke?");
            string response2 = Console.ReadLine();
            if (response2.ToLower() == "yes")
            {
                Console.WriteLine("How many programmers does it take to change a lightbulb?");
                System.Threading.Thread.Sleep(2000);//2,000ms
                Console.WriteLine("None, thats a hardware problem.");
                System.Threading.Thread.Sleep(1000);//1,000ms
                Console.WriteLine("HAHA right? Because we're SOFTWARE PROGRAMMERS.");
            }
            else
            {
                Console.WriteLine("Well I hope I made you laugh!");
            }

            {
                Console.WriteLine("Would you like to hear another joke?");
                string response3 = Console.ReadLine();
                if (response3.ToLower() == "yes")
                {
                    Console.WriteLine("Why did the variable divorce the type?");
                    System.Threading.Thread.Sleep(2000);//2,000ms
                    Console.WriteLine("It didn't feel valued");
                    System.Threading.Thread.Sleep(1000);//1,000ms
                    Console.WriteLine("HAHA, because it didnt have a value.");
                }
                else
                {
                    Console.WriteLine("Ok thats fine. Let's laugh again some other time.");
                }
            }

        }
    }
}
