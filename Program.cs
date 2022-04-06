// Формирование нового массива - Итоговая проверочная работа.

Console.Clear();

// Быстрая проверка кода.
// string[] country = { "England", "Spain", "Italy", "Russia" };

// Ввод с клавиатуры.
Console.WriteLine("Введите элементы массива через пробел.");
System.Console.WriteLine("Например: 123 sds :) 1!2A");
string[] arrEnter = Console.ReadLine().Split(' ');
System.Console.WriteLine($"\n");

// Формирование нового массива через удаление элементов из первоначального.
string[] DelElementsArray(string[] argument)
{
    do
    {        
        int quantity = new Random().Next(0, argument.Length + 1); // Количество удаляемых элементов

        for (int i = 0; i < quantity; i++)
        {
            int delIndex = new Random().Next(0, argument.Length);
            int[] indexes = { delIndex };
            argument = (from x in argument where !(from i in indexes select argument.ElementAt(i)).Contains(x) select x).ToArray();
        }
    } while (argument.Length > 3);
    return argument;
}

string[] NewArr = DelElementsArray(arrEnter);

// Печать массива.
void MethodPrintArray(string[] argument)
{
    for (int i = 0; i < argument.Length; i++)
    {
        System.Console.Write($"{argument[i]} ");
    }
}

if (NewArr.Length == 0)
{
    System.Console.WriteLine($"В новом массиве 0 элементов. \n");
}
else
{
    System.Console.Write($"Новый массив: ");
    MethodPrintArray(NewArr);
    System.Console.WriteLine($"\n");
}
