using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVP_ConsoleApp1
{
    internal class Calculator
    {
        int a, b;
        float x, y;
        double p, q;
        char value;
        
        public void Test()
        {
            Console.WriteLine($"{a} - {b}");
            Console.WriteLine($"{x} - {y}");
            Console.WriteLine($"{p} - {q}");
        }

        public void GetChar()
        {
            Console.Write("Enter Any Character between (+, -, *, /)");
            value = Convert.ToChar(Console.ReadLine());
            //value = char.Parse(Console.ReadLine());
            Console.WriteLine($"You Entered {value}");

            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Welcome {name} to C#");
        }

        public void Addition()
        {
            Console.Write("Enter First No. : " );
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Second No. : ");
            b = int.Parse(Console.ReadLine());

            int c = a + b;
            Console.WriteLine("Addition: " + c);
        }

        public void Subtraction()
        {
            Console.Write("Enter First No. : ");
            x = Convert.ToSingle(Console.ReadLine());

            Console.Write("Enter Second No. : ");
            y = float.Parse(Console.ReadLine());

            float c = x - y;
            Console.WriteLine("Subtraction: " + c);
        }

        public void Multiply()
        {
            Console.Write("Enter First No. : ");
            p = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Second No. : ");
            q = double.Parse(Console.ReadLine());

            double c = p * q;
            Console.WriteLine("Multiplication: " + c);
        }
    }
}
