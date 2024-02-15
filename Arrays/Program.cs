using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students=new string[3];
            students[0] = "Hilal";
            students[1] = "Serkan";
            students[2] = "Nida";

            string[] students2 = new string[3] { "Hilal", "Serkan","Nida"};

            foreach (string s in students)
            {
                Console.WriteLine(s);
            }

            string[,] regions=new string[5,3]   //çok boyutlu dizi
            {
                { "İstanbul","İzmit" ,"Balıkesir"},
                { "Ankara","Konya" ,"Kırıkkale"},
                { "Adana","Mersin" ,"Antalya"},
                { "Rize","Trabzon" ,"Artvin"},
                { "İzmir","Muğla" ,"Manisa"}
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }
                Console.WriteLine("***************");
            }

            Console.ReadLine();
        }
    }
}
