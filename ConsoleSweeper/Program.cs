using System;

namespace ConsoleSweeper
{
    class Program
    {
        static void Main(string[] args)
        {
            SweeperGrid g1 = new SweeperGrid();
            g1.Draw();
            Console.WriteLine("Välkommen till spelet! \nSkriv in en position att checka. \nTotalt 2 siffror mellan 1 och 5, skriv ett åt gången\nFörst x sen y.");
            if (g1.CheckPosition(ToInt(Console.ReadLine()), ToInt(Console.ReadLine())) == true)
            {
                Console.WriteLine("Här fanns en mina!");
            }
            else
            {
                Console.WriteLine("Här fanns ingen mina!");
            }
            Console.ReadLine();
        }
        static int ToInt(string number)
        {
            bool lyckad = false;
            int result = 0;
            while(lyckad == false)
            {
                lyckad = int.TryParse(number, out result);
                if (lyckad == false)
                {
                    Console.WriteLine("Skriv en giltig siffra!");
                }
            }
            return result;
            
        }
    }
}
