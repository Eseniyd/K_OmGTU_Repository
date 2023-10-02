using System.Globalization;
using System.Runtime.Intrinsics.X86;
using System.Threading.Channels;

namespace омгту
{
    class Program
    {
        static void Main()
        {
            int n, count, element, men;
            count = 0;
            n = Convert.ToInt32(Console.ReadLine());
            element = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i < n; i++)
            {
                men = Convert.ToInt32(Console.ReadLine());
                if (element > men)
                    count++;
                if (element < men)
                    break;
                element = men;
            }
            Console.WriteLine("Элементов:" + count);
        }
    }
}









