using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string[] symbol = { "+", "-", "*", "/" };
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                int a = random.Next(2, 3);
                switch (a)
                {
                    case 2:
                        {
                            string s = symbol[random.Next(0, 3)];
                            int t = random.Next(0, 100);
                            int g = random.Next(0, 100);
                            if (s == "/")
                            {

                                if (g != 0 && ((t / g) * g) == t)
                                    Console.WriteLine(t + "/" + g + "=");


                            }

                            if (s == "-")
                            {
                                if ((t - g) > 0)
                                    Console.WriteLine(t + s + g + "=");


                            }
                            else
                            {

                                Console.WriteLine(t + s + g + "=");

                            }
                            break;

                        }
                    case 3:
                        {
                            string s = symbol[random.Next(0, 3)];
                            string d = symbol[random.Next(0, 3)];
                            int t = random.Next(0, 100);
                            int g = random.Next(0, 100);
                            int h = random.Next(0, 100);

                            switch (s)
                            {
                                case "+":
                                    {
                                        if (d == "-")
                                        {
                                            if (t + g - h > 0)
                                                Console.WriteLine(t + s + g + d + h + "=");
                                        }
                                        if (d == "/")
                                        {
                                            if (h != 0 && ((g / h) * h) == g)
                                                Console.WriteLine(t + s + g + d + "=");
                                        }
                                        break;

                                    }
                                case "-":
                                    {
                                        if (d == "+")
                                        {
                                            if (t - g + h > 0)
                                                Console.WriteLine(t + s + g + d + h + "=");
                                        }
                                        if (d == "-")
                                        {
                                            if (t - g - h > 0)
                                                Console.WriteLine(t + s + g + d + h + "=");
                                        }
                                        if (d == "*")
                                        {
                                            if (t - g * h > 0)
                                                Console.WriteLine(t + s + g + d + h + "=");
                                        }
                                        if (d == "/")
                                        {
                                            if (h != 0 && ((g / h) * h) == g && (t - g / h) > 0)
                                                Console.WriteLine(t + s + g + d + h + "=");
                                        }
                                        break;

                                    }
                                case "*":
                                    {
                                        if (d == "/")
                                        {
                                            if (h != 0 && ((t * g) / h) * h == t * g)
                                                Console.WriteLine(t + s + g + d + h + "=");
                                        }
                                        if (d == "-")
                                        {
                                            if (t * g - h > 0)
                                                Console.WriteLine(t + s + g + d + h + "=");

                                        }
                                        if (d == "+" || d == "*")
                                        {
                                            Console.WriteLine(t + s + g + d + h + "=");
                                        }
                                        break;
                                    }
                                case "/":
                                    {
                                        if (g != 0 && (t / g) * g == t)
                                        {
                                            if (d == "-")
                                            {
                                                if (t / g - h > 0)
                                                    Console.WriteLine(t + s + g + d + h + "=");
                                            }
                                            if (d == "+" || d == "*")
                                                Console.WriteLine(t + s + g + d + h + "=");
                                            if (d == "/")
                                            {
                                                if (((t / g) / h) * h == (t / g) && (h != 0))
                                                    Console.WriteLine(t + s + g + d + h + "=");
                                            }
                                        }
                                        break;
                                    }

                            }
                            break;
                        }
                }
            }
            Console.ReadLine();
        }
    }

}