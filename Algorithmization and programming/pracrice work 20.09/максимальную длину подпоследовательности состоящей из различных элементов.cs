class омгту2
{
    static void Main()
    {
        int n, max_dlina, tek_posled = 1, number, predid_number;  //кол-во элементов, max длина, длина текущей послЕдовательности, текущее число, предыдущее число
        n = Convert.ToInt32(Console.ReadLine());
        max_dlina = 1;
        predid_number = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < n - 1; i++)
        {
            number = Convert.ToInt32(Console.ReadLine());
            if (number != predid_number)
            {
                tek_posled++;

            }
            else
            {
                if ((max_dlina < tek_posled) & (tek_posled > 1))
                {
                    max_dlina = tek_posled;

                }
                tek_posled = 1;
            }
            predid_number = number;
        }
        Console.WriteLine(max_dlina); // максимальную длину подпоследовательности состоящей из различных элементов
    }
}



