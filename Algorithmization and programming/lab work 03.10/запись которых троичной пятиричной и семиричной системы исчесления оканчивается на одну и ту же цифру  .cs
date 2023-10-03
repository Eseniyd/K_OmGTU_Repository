using System.Globalization;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Threading.Channels;

namespace омгту
{
    class Program
    {
        static void Main()
        {
            int n, ch, tri, five, seven, cnt;
            cnt = 0;
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                ch = Convert.ToInt32(Console.ReadLine());
                tri = ch % 3;
                five = ch % 5;
                seven = ch % 7;
                if ((tri == five) && (five == seven) && (tri == seven))
                    cnt++;
            }
            Console.WriteLine(cnt);
        }
    }
}









