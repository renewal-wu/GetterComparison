using System;

namespace GetterComparison
{
    internal class Program
    {
        public static object Test1 { get; } = new object();
        public static object Test2 => new object();
        public static object Test3 { get => new object(); }

        private static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                // 每次都能取得相同的 HashCode
                Console.WriteLine($"Test1.GetHashCode(): { Test1.GetHashCode() }");
            }

            for (int i = 0; i < 5; i++)
            {
                // 每次都會取得不同的 HashCode
                Console.WriteLine($"Test2.GetHashCode(): { Test2.GetHashCode() }");
            }

            for (int i = 0; i < 5; i++)
            {
                // 每次都會取得不同的 HashCode
                Console.WriteLine($"Test3.GetHashCode(): { Test3.GetHashCode() }");
            }

            Console.WriteLine();

            // true
            Console.WriteLine($"Test1 == Test1 ?  { Test1 == Test1 }");

            // false
            Console.WriteLine($"Test2 == Test2 ?  { Test2 == Test2 }");

            // false
            Console.WriteLine($"Test3 == Test3 ?  { Test3 == Test3 }");

            Console.ReadKey();
        }
    }
}