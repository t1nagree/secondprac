int choose;
do
{
    Console.WriteLine("Вы можете выбрать любую функцию из представленных:");
    Console.WriteLine("Введите число от 1 до 3-ёх для выбора функции:");
    Console.WriteLine("1 - Игра УГАДАЙ ЧИСЛО");
    Console.WriteLine("2 - Таблица умножения");
    Console.WriteLine("3 - Вывод делителей числа");
    Console.WriteLine("4 - Выход из программы");
    choose = Convert.ToInt32(Console.ReadLine());

    switch (choose)
    {
        case 1:
            ugaday();

            break;
        case 2:
            umnozheniye();

            break;
        case 3:
            deliteli();
            break;
    }

}
while (choose != 4);
{
    Console.WriteLine("Работа программы завершена!");
}
static void ugaday()
{
    Random ugaday = new Random();
    int i = ugaday.Next(100);
    i = Convert.ToInt32(i);
    int attemp = 0;

    int chislo;
    Console.WriteLine("Сделайте попытку и угадайте число от 0 до 100, загаданное алгоритмом компьютера");
    do
    {
        chislo = Convert.ToInt32(Console.ReadLine());
        if (chislo > i)
            Console.WriteLine("Загаданное число компьютером меньше, чем вводимое.");
        Console.WriteLine();
        if (chislo < i)
            Console.WriteLine("Загаданное число компьютером больше, чем вводимое.");
        attemp++;
    }
    while (chislo != i);

    Console.WriteLine("Поздравляю, загаданное число компьютером было отгадано, столько попыток вам понадобилось: " + attemp);

}

static void umnozheniye()
{
    int[,] umnozh = new int[9, 10];
    Console.WriteLine("Таблица умножения: ");
    for (int x = 0; x < 9; x++)
    {

        for (int y = 1; y < 10; y++)
        {
            umnozh[x, y] = (x + 1) * y;
        }
    }
    for (int x = 0; x < 9; x++)
    {
        for (int y = 1; y < 10; y++)
        {
            Console.Write(umnozh[x, y] + "\t");
        }

        Console.WriteLine();
    }
}
static void deliteli()
{
    int number = Convert.ToInt32(Console.ReadLine());
    for (int i = 1; i <= number; i++)
    {
        if (number % i == 0)
        {
            Console.Write($"{i}   ");
        }
    }
    Console.WriteLine();
}
