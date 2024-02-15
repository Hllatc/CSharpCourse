using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Value Types
            double number5= 10.4;  //64 bit yer tutar, virgülden sonra 15-16 değer tutar
            decimal number6 = 10.4m;  // virgülden sonra 28-29 tane değer tutar.
            char character = 'A';
            bool condition = true; // true veya false değeri alır.
            byte number4=0;//  0-255 değerleri arasında yer alır.   
            short number3= 32767;  // * 16 bit yer kaplar
            int number1 = 2147483647; //int sınırları - ve + 2147483647  *32 bit yer kaplar
            long number2= 9223372036854775807;  // long sınırları - ve + 9223372036854775807    *64 bit yer kaplar
            var number7 = 'A';
          
            
            Console.WriteLine("Number 4 is {0}", number4);
            Console.WriteLine("Number 3 is {0}", number3);
            Console.WriteLine("Number 1 is {0}",number1);
            Console.WriteLine("Number 2 is {0}", number2);
            Console.WriteLine("Number 5 is {0}", number5);
            Console.WriteLine("Number 6 is {0}", number6);
            Console.WriteLine("Number 7 is {0}", number7);
            Console.WriteLine(condition);
            Console.WriteLine("Character is {0}", (int)character);
            Console.WriteLine((int)Days.Friday);
            //Console.WriteLine("Hello World.");
            Console.ReadLine(); //konsolun kapanmaması için
        }
    }
    enum Days
    {
        Monday=10, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }
}
