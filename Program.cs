using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace ConsoleApp1
{
    internal class Program
    {
        static void F1()
        {
            Console.WriteLine("Hello world!");
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
            Console.Write("Add meg az első együtthatót: ");
            double a = double.Parse (Console.ReadLine()!);

            Console.Write("Add meg a második együtthatót: ");
            double b = double.Parse(Console.ReadLine()!);

            Console.Write("Add meg a harmadik együtthatót: ");
            double c = double.Parse(Console.ReadLine()!);

            double d = b * b - 4 * a * c;

            if (d > 0)
            {
                double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine($"Két valós gyök van: x1 = {x1}, x2 ={x2}");
            }
            else if (d == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"Egy valós gyök van: x = {x}");
            }
            else
            {
                Console.WriteLine("Nincs valós megoldás.");
            }
        }
        static void F10()
        {
            Console.Write("Add meg az első együtthatót: ");
            double a = double.Parse(Console.ReadLine()!);

            Console.Write("Add meg a második együtthatót: ");
            double b = double.Parse(Console.ReadLine()!);

            Console.Write("Add meg a harmadik együtthatót: ");
            double c = double.Parse(Console.ReadLine()!);

            double d = b * b - 4 * a * c;

            if (d > 0)
            {
                double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine($"Két valós gyök van: x1 = {x1}, x2 ={x2}");
            }
            else if (d == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"Egy valós gyök van: x = {x}");
            }
        }
        static void F11()
        {
            Console.WriteLine("Add meg a derékszögű háromszög egyik befogóját: ");
            int a = int.Parse(Console.ReadLine()!);

            Console.Write("Add meg a derékszögű háromszög másik befogóját: ");
            int b = int.Parse(Console.ReadLine() !);
            double c = Math.Round(Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)), 2);
            Console.WriteLine($"Az átfogó hossza: {c}");
        }
        static void F12()
        {
            Console.Write("Add meg a téglatest első élének hosszát: ");
            double a = double.Parse(Console.ReadLine()!);

            Console.Write("Add meg a téglatest második élének hosszát: ");
            double b = double.Parse(Console.ReadLine()!);

            Console.Write("Add meg a téglatest harmadik élének hosszát: ");
            double c = double.Parse(Console.ReadLine()!);

            double felszin = 2 * (a * b + a * c + b * c);
            double terfogat = a * b * c;

            Console.WriteLine($"A téglatest felszíne: {felszin}");
            Console.WriteLine($"A téglatest térfogata: {terfogat}");
        }
        static void F13()
        {
            
            Console.Write("Add meg a kör átmérőjét: ");
            double d = double.Parse(Console.ReadLine()!);

            double kerulet = Math.PI * d;
            double sugar = d / 2;
            double terulet = Math.PI * sugar * sugar;

            Console.WriteLine($"A kör kerülete: {kerulet}");
            Console.WriteLine($"A kör területe: {terulet}");
            
        }
        static void F14()
        {
            Console.Write("Add meg a körív sugarát: ");
            double r = double.Parse(Console.ReadLine()!);

            Console.Write("Add meg a középponti szöget: ");
            double szog = double.Parse(Console.ReadLine()!);

            double ivHossz = 2 * Math.PI * r * (szog / 360);
            double terulet = Math.PI * r * r * (szog / 360);

            Console.WriteLine($"A határoló ív hossza: {ivHossz}");
            Console.WriteLine($"A körívhez tartozó körcikk területe: {terulet}");
        }
        static void F15()
        {
            Console.Write("Adj meg egy pozitív egész számot: ");
            int n = int.Parse(Console.ReadLine()!);

            for (int i = 1; i <= n; i++)
            {
                Console.Write(i);
                if (i < n)
                    Console.Write(" ");
            }
        }
        static void F16()
        {
            Console.Write("Adj meg egy pozitív egész számot: ");
            int n = int.Parse(Console.ReadLine()!);

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
              
            }
        }
        static void F17()
        {
            Console.Write("Adj meg egy pozitív egész számot: ");
            int n = int.Parse(Console.ReadLine()!);
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                   Console.WriteLine($"A szám osztói: {i}");
                }
            }
        }
        static void F18() 
        {
            Console.Write("Adj meg egy pozitív egész számot: ");
            int n = int.Parse(Console.ReadLine()!);
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                { 
                    sum += i;
                }
            }
            Console.WriteLine($"A szám osztóinak összege: {sum}");
        }
        static void F19()
        {
            Console.Write("Adj meg egy pozitív egész számot: ");
            int n = int.Parse(Console.ReadLine()!);

            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }

            if (sum == 2 * n)
            {
                Console.WriteLine($"{n} tökéletes szám.");
            }
            else
            {
                Console.WriteLine($"{n} nem tökéletes szám.");
            }
        }
        static void F20()
        {
            Console.Write("Hatványalap: ");
            double alap = double.Parse(Console.ReadLine()!);

            Console.Write("Kitevő: ");
            double kitevo = double.Parse(Console.ReadLine()!);

            double eredmeny = Math.Pow(alap, kitevo);

            Console.WriteLine($"Hatványérték: {eredmeny}");
        }
        static void F21()
        {
            double number;
            do
            {
                Console.Write("Adj meg egy pozitív számot: ");
                if (!double.TryParse(Console.ReadLine(), out number) || number <= 0)
                {
                    Console.WriteLine("Hiba: csak pozitív számot adj meg!");
                }
            } while (number <= 0);

            Console.WriteLine($"A megadott pozitív szám: {number}");
        }
        static void F22()
        {
            int sum = 0;
            int number;

            do
            {
                Console.Write("Adj meg egy számot (10-nél kisebbet): ");
                if (int.TryParse(Console.ReadLine(), out number) && number < 10)
                {
                    sum += number;
                }
            } while (number < 10);

            Console.WriteLine($"A beolvasott (10-nél kisebb) számok összege: {sum}");
        }
        static void F23()
        {
            Console.Write("Kérek egy egész számot: ");
            int n = int.Parse(Console.ReadLine()!);

            int original = n;
            int count = 0;

            while (n % 2 == 0 && n > 0)
            {
                n /= 2;
                count++;
            }

            Console.Write($"{original} = ");
            for (int i = 0; i < count; i++)
            {
                Console.Write("2*");
            }
            Console.WriteLine($"{n}");
        }
        static void F24()
        {
            string input;
            do
            {
                Console.Write("Írd be az 'alma' szót: ");
                input = Console.ReadLine()!;
                if (input != "alma")
                {
                    Console.WriteLine("Nem ezt kértem :) !");
                }
            } 
            while (input != "alma");

            Console.WriteLine("Az alma gyümölcs!");
        }
        static void F25()
        {
            Console.Write("Kérek egy egész számot: ");
            int n = int.Parse(Console.ReadLine()!);

            int eredeti = n;
            int oszto = 0;

            while (n > 3) 
            {
                n -= 3;
                oszto++;
            }
            Console.WriteLine($"{eredeti} = 3*{oszto}+{n} ");
        }
        static void Fs26()
        {
            Console.Write("Kérek egy egész számot: ");
            int n = int.Parse(Console.ReadLine()!);

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine("Nem prímszám!");
                }
                else
                {
                    Console.WriteLine("Prímszám!");
                }
            }
        }
        static void F26()
        {
            Console.Write("Kérek egy egész számot: ");
            int n = int.Parse(Console.ReadLine()!);

            if (n < 2)
            {
                Console.WriteLine("Nem prímszám!");
                return;
            }

            bool isPrime = true;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                Console.WriteLine("Prímszám!");
            }
            else
            {
                Console.WriteLine("Nem prímszám!");
            }
        }
        static void F27()
        {
            Console.Write("Adj meg egy számot: ");
            int n = int.Parse(Console.ReadLine()!);

            if (n < 2)
            {
                Console.WriteLine("Nincs prímszám!");
                return;
            }
            for (int i = 2; i <= n; i++)
            {
                bool isPrime = true;
                for (int szam = 2; szam <= Math.Sqrt(i); szam++)
                {
                    if (i % szam == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.Write(i + " ");
                }
            }

        }
        static void F28()
        {
            Console.Write("Adj meg egy számot: ");
            int n = int.Parse(Console.ReadLine()!);

            Console.Write("Prím osztók: ");
            for (int i = 2; i <= n; i++)
            {
                bool isPrime = true;
                for (int szam = 2; szam <= Math.Sqrt(i); szam++)
                {
                    if (i % szam == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime && n % i == 0)
                {
                    Console.Write($"{i} ");
                }
            }
        }


        static void Main(string[] args) 
        {
            F28();
        }
    }
}
