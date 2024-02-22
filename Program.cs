using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строки через запятую без пробелов(слова на английском): ");
        string input = Console.ReadLine();

        // Разбиваем введенные строки по запятой и создаем массив строк
        string[] inputArray = input.Split(',');

        // Формируем новый массив из строк, длина которых меньше или равна 3 символам
        string[] resultArray = FilterStrings(inputArray);

        // Выводим результат
        Console.WriteLine("Результат:");
        foreach (string str in resultArray)
        {
            Console.WriteLine(str);
        }
    }

    static string[] FilterStrings(string[] inputArray)
    {
        // Используем LINQ для фильтрации строк по длине
        var result = from str in inputArray
                     where str.Length <= 3
                     select str;

        // Преобразуем результат в массив строк
        return result.ToArray();
    }
}