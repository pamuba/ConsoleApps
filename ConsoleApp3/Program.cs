using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i < 26; i++)
            {
                Console.WriteLine(DateTime.Now);   
                Console.BackgroundColor = (ConsoleColor)i;
                Thread.Sleep(1000);
                Console.Clear();
            }
            //Console.WriteLine("Hello");
            //Console.BackgroundColor = ConsoleColor.Blue;
            //int[] arr = new int[]{ 11, 22, 33, 44, 55 };
            //int[] arr1 = new int[5];

            //for (int i = 0, j=4; i < 5; i++,j--)
            //{
            //    arr1[i] = arr[j];
            //}
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(arr1[i]);
            //}
            // int i = 1239;// / %
            // int sum = 0;
            // while (i>0)
            // {

            //     sum += i % 10;
            //     i = i / 10;
            // }
            //Console.WriteLine(sum);

            //int i = 0;
            //for (;;)
            //{
            //    Console.WriteLine(i);
            //    i++;

            //    if(i == 5)
            //    {
            //        break;
            //    }
            //}

            //ConsoleKeyInfo i = Console.ReadKey();
            //Console.WriteLine(i.Key);


            //Console.Write("Hello");
            //Console.Write("World");

            //int i; 
            //int.TryParse(Console.ReadLine(),out i);
            //Console.WriteLine(i);

            //try
            //{
            //    int i = Convert.ToInt32(Console.ReadLine());
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //String name;
            //Console.WriteLine("Enter a name:");
            //name = Console.ReadLine();
            //Console.WriteLine("Hello " + name);


            //int i = 99;
            //Console.WriteLine("Value of i:" + i.ToString());

        }
    }
}
