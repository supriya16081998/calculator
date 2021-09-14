using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("a.Addition s.Subtraction m.Multiplication d.Division ");
            Console.WriteLine("Enter your choice:");
            char ch = Convert.ToChar(Console.ReadLine());
            
            int a, b;
             
            int result=0;
            switch (ch)
            {
                case 'a':
                    Console.WriteLine("Enter Two Numbers:");
                    a = Convert.ToInt32(Console.ReadLine());
                    b = Convert.ToInt32(Console.ReadLine());
                    result = a + b;
                    Console.WriteLine("Addition of two no is=" + result);

                    break;

                case 's':
                    Console.WriteLine("Enter Two Numbers:");
                    a = Convert.ToInt32(Console.ReadLine());
                    b = Convert.ToInt32(Console.ReadLine());
                    result = a - b;
                    Console.WriteLine("Subtraction of two no is=" + result);
                    break;

                case 'm':
                    Console.WriteLine("Enter Two Numbers:");
                    a = Convert.ToInt32(Console.ReadLine());
                    b = Convert.ToInt32(Console.ReadLine());
                    result = a * b;
                    Console.WriteLine("Multiplication of two no is=" + result);
                    break;

                case 'd':
                    Console.WriteLine("Enter Two Numbers:");
                    a = Convert.ToInt32(Console.ReadLine());
                    b = Convert.ToInt32(Console.ReadLine());
                    result = a / b;
                    Console.WriteLine("Division of two no is=" + result);
                    break;

                default:
                    Console.WriteLine("Your choice is wrong");
                    break;

                    

            }
            Console.ReadLine();
        }
    }
}
