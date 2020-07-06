using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soal_Programing_Kredit_Plus
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Soal No. 1");
            int a = 5, b = 3;
            Console.WriteLine("Sebelum nilai dipindahkan a= " + a + " b= " + b);
            a = a + b; //a=8 (5+3)      
            b = a - b; //b=5 (8-3)      
            a = a - b; //a=3 (8-5)   
            Console.WriteLine("Setelah nilai dipindahkan a= " + a + " b= " + b);

            Console.WriteLine("=================================================");

            //Soal No.2
            Console.WriteLine("Soal No. 2");
            int[] x = new int[] { 20, 10, 50, 46, 26, 87, 25, 5, 97, 24 };
            int temp = 0;

            for (int i = 0; i <= x.Length - 1; i++)
            {
                for (int j = i + 1; j < x.Length; j++)
                {
                    if (x[i] > x[j])
                    {
                        temp = x[i];
                        x[i] = x[j];
                        x[j] = temp;
                    }
                }
            }
            Console.WriteLine("Urutan array dari yang terkecil :");
            foreach (var item in x)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

        }
    }
}
