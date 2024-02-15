using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = 11;

            if (number==10)
            {
                Console.WriteLine("Sayı 10 dur.");
            }
            else if(number==20)
            {
                Console.WriteLine("Sayı 20 dir.");
            }
            else
            {
                Console.WriteLine("Sayı 10 veya 20 değildir.");
            }

            Console.WriteLine(number == 10 ? "sayı ondur." : "sayı on değildir.");


            switch (number)
            {
                case 10:
                    Console.WriteLine("Sayı 10 dur.");
                    break;
                case 20:
                    Console.WriteLine("Sayı 20 dir.");
                    break;
                default:
                    Console.WriteLine("Sayı 10 veya 20 değildir.");
                    break;

            }

            if(number>=0 && number <= 100)
            {
                Console.WriteLine("Number 0-100 arasındadır.");
            }else if(number>100 && number <= 200)
            {
                Console.WriteLine("Number 101-200 arasındadır.");
            }
            else if(number >200 || number<0)
            {
                Console.WriteLine("Number less than 0 or greater than 200");
            }

            if (number < 100)
            {
                if (number>=90) 
                {
                    Console.WriteLine("Number 100 den küçük ve 90 dan büyüktür.");
                }
            }

            Console.ReadLine();
        }
    }
}
