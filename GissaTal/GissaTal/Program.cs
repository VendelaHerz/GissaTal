using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GissaTal
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = 0;
            while (y == 0) //"Spela igen-funktionen" la jag till i efterhand.
            {
                Random Slump = new Random();
                int tal = (Slump.Next(101));
                int gissning = 0;
                int försök = 0;
                int x = 1;
                Console.WriteLine("Gissa vilket tal mellan 1 och 100 jag tänker på!");

                while (x == 1)
                {
                    gissning = int.Parse(Console.ReadLine());
                    försök++;

                    if (gissning == tal)
                    {
                        x++;
                    }
                    else if (gissning > tal)
                    {
                        Console.WriteLine("Talet jag tänker på är mindre än det du skrev!");
                    }
                    else
                    {
                        Console.WriteLine("Talet jag tänker på är större än det du skrev!");
                    }

                }
                Console.WriteLine("Rätt! Talet jag tänkte på var " + tal + "!");
                Console.WriteLine("Du behövde " + försök + " försök för att komma på det.");

                // Det som finns under detta la jag till i efterhand.
                Console.WriteLine();
                Console.WriteLine("Vill du gissa en gång till?");
                string svar = Console.ReadLine();
                if (svar == "Nej" || svar== "nej" || svar== "NEJ" || svar== "nope")
                {
                    y++;
                }
                else
                {
                    Console.WriteLine("Okej! Vi kör igen!");
                    Console.WriteLine();
                }
            }
            Console.WriteLine("Okej, hejdå!");
        }
    }
}
