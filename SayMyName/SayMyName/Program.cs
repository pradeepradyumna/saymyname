using System;

namespace SayMyName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Environment.UserName.ToUpper());
            Console.ReadLine();
        }
    }
}
