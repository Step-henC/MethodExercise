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
        }
    }
}
