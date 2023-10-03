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
            int n;
            bool proverka = true;
            n = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                int a = Convert.ToInt32(Console.ReadLine());
                int summ = 0;
                while (a > 0)
                {
                    summ += a % 10;
                    a /= 10;
                }
                if (summ % 7 != 0)
                            proverka = false;
            }
            Console.WriteLine(proverka);
        }
    }
}









