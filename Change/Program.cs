using System;

namespace Change
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Include range:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Find f1 = new Find();
            Console.WriteLine($"Sum of numbers:{f1.FindSum(a,b)}\nCount of range numbers:{f1.FindCount(a,b)}");
 
        }
    }
}
