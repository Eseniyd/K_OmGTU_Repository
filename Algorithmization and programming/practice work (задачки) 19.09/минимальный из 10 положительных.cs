using System.Globalization;
using System.Runtime.Intrinsics.X86;
using System.Threading.Channels;

namespace омгту
{
    class Program
    {
        static void Main()
        {
            short a, b;
            a = Convert.ToInt16(Console.ReadLine());
            a = Math.Abs(a);
            for (byte i = 1; i < 10; i++)
            {
                b = Convert.ToInt16(Console.ReadLine());
                if ((a > b) && (b > 0) && (a > 0))
                    a = b;
            }
            Console.WriteLine(a);
        }

    }
}









