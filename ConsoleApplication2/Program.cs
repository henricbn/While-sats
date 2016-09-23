using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i++ < 100)
            {
                Console.WriteLine(i);
            }
            //övning 2
            Console.Write("Skriv in lösenord:");
            string inmatat = Console.ReadLine();

            while ( inmatat != "korvstroganoff")
            {
                Console.WriteLine("Fel lösenord");
                inmatat = Console.ReadLine();
            }
            //övning 3
            i = 1;
            while (i<=100)
            {
                Console.WriteLine(i);
                i++;
            }
            //övning 4
            i = 10;
            while (i>=1)
            {
                Console.WriteLine(i);
                i--;
            }
            //övning 5
            while (true)
            {
                Console.WriteLine("ost");
            }
            //övning 6
            Console.WriteLine("gissa ett tal mellan 1 och 100:");
            int = Console.ReadLine();
            i = 36;
            while (i < 100; i > 0;)
            {
                Console.WriteLine();
            }
        }
    }
}
