using System;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Display(0);
            Console.ReadLine();


        }


        public static void Display(int count)
        {
           if(count<10)

           {
                Display(count + 1);
                Console.WriteLine(count);
               
               
               
            
            
            }
        }
    }
}
