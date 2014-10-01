using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {    if ((i % 3==0) && (i % 5==0)) {
                Console.WriteLine("FizzFuzz");

            } else if(i%3==0){
                   Console.WriteLine("Fizz");
               }
               else if (i%5==0) {
                  Console.WriteLine("Fuzz");
               }  else Console.WriteLine(i);
            } Console.ReadLine();
            }


        }
    }

