class омгту2
{
    static void Main()
    {
        int n, k; // длина последовательности, число
        int count = 0;
        n = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            k = Convert.ToInt32(Console.ReadLine());
            if (k % i != 0)
            {
                count++;
            }
        }
        Console.WriteLine(count == 0); // все ли элементы последовательности кратны номеру под которым они считываются

    }
}





