class омгту2
{
    static void Main()
    {
        int kolichestvo, number, predid_number, raznica, perekluchatel = 1; // количество, число текущее, предыдущее число, разница, переключатель
        kolichestvo = Convert.ToInt32(Console.ReadLine());
        predid_number = Convert.ToInt32(Console.ReadLine());
        number = Convert.ToInt32(Console.ReadLine());
        raznica = predid_number - number;
        if (raznica > 0)
        {
            for (int i = 0; i < kolichestvo - 2; i++)
            {
                predid_number = number;
                number = Convert.ToInt32(Console.ReadLine());
                if ((predid_number - number) != raznica)
                {
                    perekluchatel = 0;
                }
            }
        }
        else
        {
            perekluchatel = 0;
        }
        if (perekluchatel == 1)
        {
            Console.WriteLine("Последовательность является равномено убывающей");
        }
        else
        {
            Console.WriteLine("Последовательность не является равномено убывающей"); //образует ли заданная последовательность равномерно убывающую последовательность элементов
        }
    }
}


