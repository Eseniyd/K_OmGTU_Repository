using System.Globalization;
using System.Runtime.Intrinsics.X86;
using System.Threading.Channels;

namespace омгту
{
    class Program
    {
        static void Main()
        {
            int n, a, b, dlina_max, count;
            count = 1;
            dlina_max = 0;
            n = Convert.ToInt32(Console.ReadLine());
            a = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                b = Convert.ToInt32(Console.ReadLine());
                if (a < b)
                    count++;
                if (a >= b) {
                    if ((count > dlina_max) && (count != 1))
                        dlina_max = count;
                        count = 1;
                }
            }
            Console.WriteLine(dlina_max);
        }
    }
}









