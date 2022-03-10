using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Exercise_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string color = Console.ReadLine();
            int height = Convert.ToInt32(Console.ReadLine());
            string animal = Console.ReadLine();
            int speed = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Yesterday, I saw a {animal} riding a {color} bicycle going {speed} mph. When I asked where he is going, he said he going to have a {height} pizza with another {animal}. His face was beat {color}");

            add(height, speed);
            Subtract(height, speed);
            Multiply(height, speed);
            Divide(height, speed);
            moduluss(height, speed);


            int add(int x, int y)
            {

                return x + y;
            }

            int Subtract(int a, int b)
            {

                return a - b;
            }
            int Multiply(int c, int d)
            {

                return c * d;
            }
            int Divide(int a, int b)
            {

                return (a / b);
            }
            int moduluss(int g, int h)
            {

                return g % h;
            }
        }
    }
}
