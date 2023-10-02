using System.Globalization;
using System.Runtime.Intrinsics.X86;
using System.Threading.Channels;

namespace омгту
{
    class Program
    {
        static void Main()
        {
            int a, b;
            a = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < 10; i++)
            {
                b = Convert.ToInt32(Console.ReadLine());
                if (a < b) a = b;
            }
            Console.WriteLine(a);
        }

    }
}









