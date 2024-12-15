using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace blabla
{

    class Name
    {
        static public void Main()
        { 
            
            int[] chisla = new int[4];
            {
                chisla[0] = Convert.ToInt32(Console.ReadLine());
                chisla[1] = Convert.ToInt32(Console.ReadLine());
                chisla[2] = Convert.ToInt32(Console.ReadLine());
                chisla[3] = Convert.ToInt32(Console.ReadLine());
            }

            int max = Int32.MinValue;
            int min = Int32.MaxValue;
            
            for (int i = 0; i < chisla.Length; i++)
            {
                if (chisla[i] > max)
                {
                    max = chisla[i];
                }
            }

            for (int i = 0; i < chisla.Length; i++)
            {
                if (chisla[i] < min)
                {
                    min = chisla[i];
                }
            }
            
            Console.WriteLine("Максимальное число : " + max);
            Console.WriteLine("Минимальное число : " + min);

            foreach (int item in chisla)
            {
                Console.WriteLine("Числа из массива : " + item);
            }

            double arifSred = chisla.Average();

            Console.WriteLine("Среднее арифмитическое : " + arifSred);

            Console.ReadKey();
       
        


        }
            }
        }
