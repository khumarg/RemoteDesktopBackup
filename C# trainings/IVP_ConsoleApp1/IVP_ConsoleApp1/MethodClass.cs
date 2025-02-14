using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVP_ConsoleApp1
{
    internal class MethodClass
    {

        /*
            Method Overloading: Methods will have same name but different signature.
        
            Signature:
                1. No. of parameters must be different.
                2. No. of parameters are same then their datatypes must be different.
                3. No. of parameters are same, datatypes are also same then their sequence must be different.
        */
        public void addition()      // method will not return any data.
        {
            int a = 10, b = 20; 
            int c = a + b;

            Console.WriteLine(c);
        }

        public void addition(int a, int b) // method will not return any data.
        { 
            int c = a + b;
            Console.WriteLine(c);
        }

        public void addition(float a, float b)  // method will not return any data.
        {
            float c = a + b;
            Console.WriteLine(c);
        }

        public void addition(int a, float b)  // method will not return any data.
        {
            float c = a + b;
            Console.WriteLine(c);
        }

        public void addition(float b, int a)  // method will not return any data.
        {
            float c = a + b;
            Console.WriteLine(c);
        }

        public int multiply(int a, int b, int c)
        {
            return a * b + c;
        }

        // Call by value
        public void Data(int a)
        {
            a *= a;
            Console.WriteLine($"a = {a}");
        }

        // Call by reference
        public void Data1(ref int a)
        {
            a *= a;
            Console.WriteLine($"a = {a}");
        }

        // Using Out Parameters
        public void Data2(ref int a, out int x, out int y)
        {
            a *= a;
            x = a * a;
            y = x * a;
            Console.WriteLine($"a = {a}");
        }

        public int Data3(ref int a, out int x, out int y)
        {
            x = a * a;
            y = x * a;
            return a = a * a;
        }

    }
}
