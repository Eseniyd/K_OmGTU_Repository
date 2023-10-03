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
            int n, a, cnt;
            cnt = 0;
            n = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                a = Convert.ToInt32(Console.ReadLine());
                while (a > 0)
                {
                    if(a % 10 == 7)
                    {
                        cnt++;
                        break;
                    }
                    a = a / 10;
                }
                Console.WriteLine(cnt);
            }

        }
    }
}









