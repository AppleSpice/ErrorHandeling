using System;

namespace ErrorHandeling
{
    class Program
    {
        static void Main(string[] args)
        {
            RunErrorHandling();
            Console.ReadKey();
        }

        static void RunErrorHandling()
        {
            Error_Handling.TryCatchMeOutside.MyErrors();
        }
    }
}
