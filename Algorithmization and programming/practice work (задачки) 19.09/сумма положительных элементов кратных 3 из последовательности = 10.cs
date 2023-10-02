using System.Globalization;
using System.Runtime.Intrinsics.X86;
using System.Threading.Channels;

namespace омгту
{
    class Program
    {
        static void Main()
        {
            int a, summ;
            summ = 0;
            for (int i = 0; i < 10; i++)
            {
                a = Convert.ToInt32(Console.ReadLine());
                if (a > 0)
                    if (a % 3 == 0)
                        summ += a;
            }
            Console.WriteLine(summ);
        }

    }
}









