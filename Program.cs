// Удаление элемента из массива по индексу

Console.Clear();

string[] country = { "England", "Spain", "Italy", "Russia" };
// string[] country = { "England", "Spain"};

int lenght = country.Length;

int count = 1;

// do-while
do
{

    System.Console.WriteLine($"Этап: {count}");

    int quantity = new Random().Next(1, lenght + 1);
    System.Console.WriteLine($"Количество шагов удаления: {quantity} \n");

    for (int i = 0; i < quantity; i++)
    {
        lenght = country.Length;
        System.Console.WriteLine($"Шаг {i + 1}: Длинна массива после каждого удаления: {lenght}");

        int delIndex = new Random().Next(0, lenght - 1);
        System.Console.WriteLine($"Индекс удаляемого элемента: {delIndex} \n");

        int[] indexes = { delIndex };
        country = (from x in country where !(from i in indexes select country.ElementAt(i)).Contains(x) select x).ToArray();
    }

    System.Console.WriteLine($"Длина массива после удаления элементов: {country.Length} \n");

    count++;

} while (country.Length > 3);

// Печать массива
void MethodPrintArray(string[] argument)
{
    for (int i = 0; i < argument.Length; i++)
    {
        System.Console.Write($"{argument[i]} ");
    }
    // System.Console.WriteLine();
}

if (country.Length == 0)
{
    System.Console.WriteLine($"Элементов в массиве не осталось \n");
}
else
{
    System.Console.Write($"Оставшиеся элементы массива: ");
    MethodPrintArray(country);
    System.Console.WriteLine($" \n ");
}
