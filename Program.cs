class омгту2
{
    static void Main()
    {
        int n, min_dlina, tekDlina = 1, number, predid_number;  //кол-во элементов, минимальная длина, длина текущей послндовательности, текущее число, предыдущее число
        n = Convert.ToInt32(Console.ReadLine());
        min_dlina = n;
        predid_number = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < n - 1; i++)
        {
            number = Convert.ToInt32(Console.ReadLine());
            if (number == predid_number)
            {
                tekDlina++;

            }
            else
            {
                if ((min_dlina > tekDlina) & (tekDlina > 1))
                {
                    min_dlina = tekDlina;

                }
                tekDlina = 1;
            }
            predid_number = number;
        }
        Console.WriteLine(min_dlina); // минимальная длина подпоследовательности
    }
}





