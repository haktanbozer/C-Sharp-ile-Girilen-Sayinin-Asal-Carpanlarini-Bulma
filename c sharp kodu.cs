using System;
 
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i;
            System.Console.Write("Bir sayı giriniz : \n");
            n = int.Parse(System.Console.ReadLine());
 
            i = 2;
 
            while (n != 1)
            {
                if (n % i == 0)
                {
                    System.Console.Write("{0} ", i);
                    n /= i;
                }
                else
                    i++;
            }
            System.Console.WriteLine();
 
        }
    }
}
