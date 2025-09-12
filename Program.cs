using System.ComponentModel;

namespace ConsoleApp1
{
    internal class Program
    {
        static void F1()
        {
            Console.WriteLine("Hello, World!");
        }

        static void F2()
        {
            Console.Write("Add meg a neved: ");
            string name = Console.ReadLine()!;
            Console.WriteLine($"Szia {name} !");
        }
        static void F3() 
        {
            Console.Write("Adj meg egy számot: ");
            int? number = null;
            do
            {
                try
                {
                    number = int.Parse(Console.ReadLine()!);
                    Console.WriteLine($"A szám kétszerese: {number * (long)2}");
                }
                catch (FormatException)
                {
                    Console.Write("Hiba, add meg újra: ");
                }
                catch (OverflowException)
                {
                    Console.Write($"A megadott számnak {int.MinValue} és {int.MaxValue} közti értéknek kell lennie");
                }
            }
            while (number is null);
        }
        static void F4()
        {
            Console.Write("Add meg az első számot: ");
            double first = double.Parse(Console.ReadLine()!);

            Console.Write("Add meg a második számot: ");
            int second = int.Parse(Console.ReadLine()!);

            Console.WriteLine($"Összegük:{first + second}");
            Console.WriteLine($"Különbségük: {first - second}");
            Console.WriteLine($"Szorzatuk: {first * second}");
            Console.WriteLine($"Hányadosuk: {first / second}");
        }
        static void F5()
        {
            Console.Write("Add meg az első számot: ");
            int first = int.Parse(Console.ReadLine()!);

            Console.Write("Add meg a második számot: ");
            int second = int.Parse(Console.ReadLine()!);

            if (first > second)
            {
                Console.WriteLine($"A nagyobb szám: {first} ");
            }
            else if (second > first)
            {
                Console.WriteLine($"A nagyobb szám: {second} ");
            }
            else
            {
                Console.WriteLine($"A két szám egyenlő");
            }
        }
        static void F6()
        {
            Console.Write("Add meg az első számot: ");
            int first = int.Parse(Console.ReadLine()!);

            Console.Write("Add meg a második számot: ");
            int second = int.Parse(Console.ReadLine()!);

            Console.Write("Add meg a harmadik számot: ");
            int third = int.Parse(Console.ReadLine()!);

            if (first > second && second > third)
            {
                Console.WriteLine($"A legkisebb szám: {third}");
            }
            else if (third > second && second > first) 
            {
                Console.WriteLine($"A legkisebb szám: {first}");
            }
            else 
            {
                Console.WriteLine($"A legkisebb szám: {second}");
            }
        }
        static void F7()
        {
            Console.Write("Add meg az első oldal hosszát: ");
            double a = double.Parse(Console.ReadLine()!);

            Console.Write("Add meg a második oldal hosszát: ");
            double b = double.Parse(Console.ReadLine()!);

            Console.Write("Add meg a harmadik oldal hosszát: ");
            double c = double.Parse(Console.ReadLine()!);

            if (a < (b + c) && b < (a + c) && c < (a + b))
            {
                Console.WriteLine($"A háromszög szerkeszthető!");
            }
            else
            {
                Console.WriteLine($"Nem szerkeszthető háromszög!");
            }
        }
        static void F8() 
        {
            Console.Write("Add meg az első számot: ");
            int first = int.Parse(Console.ReadLine()!);

            Console.Write("Add meg az első számot: ");
            int second = int.Parse(Console.ReadLine()!);

            Console.WriteLine($"A számok számtani közepe: {(first+second)/2}");
            Console.WriteLine($"A számok mértani közepe: {Math.Sqrt(first*second)}");
        }
        static void F9()
        {
            Console.Write("Add meg az első együtthatót");
            double a = double.Parse (Console.ReadLine()!);

            Console.Write("Add meg a második együtthatót");
            double b = double.Parse(Console.ReadLine()!);

            Console.Write("Add meg a harmadik együtthatót");
            double c = double.Parse(Console.ReadLine()!);

            if 
        }

        static void Main(string[] args) 
        {
            F8();
        }
    }
}
