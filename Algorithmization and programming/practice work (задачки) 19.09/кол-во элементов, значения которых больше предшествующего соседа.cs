using System.Globalization;
using System.Runtime.Intrinsics.X86;
using System.Threading.Channels;

namespace омгту
{
    class Program
    {
        static void Main()
        {
            int element, n, count, bol;
            count = 0;
            n = Convert.ToInt32(Console.ReadLine());
            element = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i<n; i++)
            {
                bol = Convert.ToInt32(Console.ReadLine());
                if (element < bol)
                    count += 1;
                element = bol;
            }
            Console.WriteLine(count);
        }
    }
}









