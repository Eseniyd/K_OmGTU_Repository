using System.Globalization;
using System.Runtime.Intrinsics.X86;
using System.Threading.Channels;

namespace омгту
{
    class Program
    {
        static void Main()
        {
            int n, element_l, big, element_r, count;
            count = 0;
            n = Convert.ToInt32(Console.ReadLine());
            element_l = Convert.ToInt32(Console.ReadLine());
            big = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < n-1; i++)
            {
                element_r = Convert.ToInt32(Console.ReadLine());
                if ((element_l < big) && (big > element_r))
                    count++;
                element_l = big;
                big = element_r;
            }
            Console.WriteLine("Элементов: " + count);
        }
    }
}









