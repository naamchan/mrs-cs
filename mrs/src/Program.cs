using System;

namespace MRS
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            foreach (var arg in args)
            {
                Console.WriteLine(arg);
            }
        }
    }
}
