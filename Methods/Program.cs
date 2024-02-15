using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Add();
            var result=Add2(10,20);
            Console.WriteLine(result);

            int number1 = 20;
            int number2 = 100;
            var result2= Add3(ref number1, out number2);  //bellekte olan değer değişir ADD3 de
            Console.WriteLine(result2);
            Console.WriteLine(number1);

            Console.WriteLine(Multiply(2,3));
            Console.WriteLine(Multiply(2, 3,4));

            Console.WriteLine(Add4(1,2,3,4,5,6));
            Console.ReadLine();
        }
        static void Add() 
        {
            Console.WriteLine("Added.");
        }
        static int Add2(int number1, int number2) 
        { 
            var result=number1 + number2;
            return result;
        }
        static int Add3(ref int number1, out int number2)
        {
            number1 = 30;
            number2 = 25;
            var result = number1 + number2;
            return result;
        }
        static int Add4(params int[] numbers)
        {
            var result = numbers.Sum(x => x);
            return result;
        }
        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        static int Multiply(int number1, int number2,int number3)
        {
            return number1 * number2*number3;
        }
    }
}
