using System.Globalization;
using System.Runtime.Intrinsics.X86;
using System.Threading.Channels;

namespace омгту
{
    class Program
    {
        static void Main()
        {
            int a, count;
            count = 0;
            for (int i = 0; i < 10; i++)
            {
                a = Convert.ToInt32(Console.ReadLine());
                if (a < 0)
                    count += 1;
            }
            Console.WriteLine(count);
        }

    }
}









