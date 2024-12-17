using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Выберите номер задания:");
        Console.WriteLine("1. Найти среднее значение между четырьмя числами");
        Console.WriteLine("2. Калькулятор");
        Console.WriteLine("3. Конвертация температуры");
        Console.WriteLine("4. Определение имени файла по пути");
        Console.WriteLine("5. Нахождение самого длинного слова в предложении");
        Console.WriteLine("6. Перемножение двух массивов");
        Console.WriteLine("7. Поиск максимального и минимального числа из пяти введенных");
        Console.WriteLine("8. Вывод пирамиды из чисел");
        Console.WriteLine("9. Полная таблица умножения");
        Console.WriteLine("10. Операции с цифрами целого числа");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                FindAverage();
                break;
            case 2:
                Calculator();
                break;
            case 3:
                TemperatureConverter();
                break;
            case 4:
                GetFileNameFromPath();
                break;
            case 5:
                FindLongestWord();
                break;
            case 6:
                MultiplyArrays();
                break;
            case 7:
                FindMaxMin();
                break;
            case 8:
                PrintPyramid();
                break;
            case 9:
                PrintMultiplicationTable();
                break;
            case 10:
                DigitOperations();
                break;
            default:
                Console.WriteLine("Неверный выбор.");
                break;
        }
    }

    static void FindAverage()
    {
        Console.WriteLine("Введите четыре числа:");
        double num1 = double.Parse(Console.ReadLine());
        double num2 = double.Parse(Console.ReadLine());
        double num3 = double.Parse(Console.ReadLine());
        double num4 = double.Parse(Console.ReadLine());

        double average = (num1 + num2 + num3 + num4) / 4;
        Console.WriteLine($"Среднее значение: {average}");
    }

    static void Calculator()
    {
        Console.WriteLine("Введите первое число:");
        double num1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите второе число:");
        double num2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Выберите действие (+, -, *, /):");
        char operation = Console.ReadLine()[0];

        double result = operation switch
        {
            '+' => num1 + num2,
            '-' => num1 - num2,
            '*' => num1 * num2,
            '/' => num1 / num2,
            _ => double.NaN
        };

        Console.WriteLine($"Результат: {result}");
    }

    static void TemperatureConverter()
    {
        Console.WriteLine("Введите температуру:");
        double temp = double.Parse(Console.ReadLine());
        Console.WriteLine("Выберите единицу (C - Цельсий, K - Кельвин, F - Фаренгейт):");
        char unit = Console.ReadLine()[0];

        if (unit == 'C')
        {
            Console.WriteLine($"В Кельвинах: {temp + 273.15}");
            Console.WriteLine($"В Фаренгейтах: {temp * 9 / 5 + 32}");
        }
        else if (unit == 'K')
        {
            Console.WriteLine($"В Цельсиях: {temp - 273.15}");
            Console.WriteLine($"В Фаренгейтах: {temp * 9 / 5 - 459.67}");
        }
        else if (unit == 'F')
        {
            Console.WriteLine($"В Цельсиях: {(temp - 32) * 5 / 9}");
            Console.WriteLine($"В Кельвинах: {(temp - 32) * 5 / 9 + 273.15}");
        }
        else
        {
            Console.WriteLine("Неверная единица.");
        }
    }

    static void GetFileNameFromPath()
    {
        Console.WriteLine("Введите путь к файлу:");
        string path = Console.ReadLine();
        string fileName = System.IO.Path.GetFileName(path);
        Console.WriteLine($"Имя файла: {fileName}");
    }

    static void FindLongestWord()
    {
        Console.WriteLine("Введите предложение:");
        string sentence = Console.ReadLine();
        string[] words = sentence.Split(' ');
        string longestWord = "";

        foreach (string word in words)
        {
            if (word.Length > longestWord.Length)
            {
                longestWord = word;
            }
        }

        Console.WriteLine($"Самое длинное слово: {longestWord}");
    }

    static void MultiplyArrays()
    {
        Console.WriteLine("Введите размер массивов:");
        int size = int.Parse(Console.ReadLine());
        int[] array1 = new int[size];
        int[] array2 = new int[size];
        int[] resultArray = new int[size];

        Console.WriteLine("Введите элементы первого массива:");
        for (int i = 0; i < size; i++)
        {
            array1[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Введите элементы второго массива:");
        for (int i = 0; i < size; i++)
        {
            array2[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < size; i++)
        {
            resultArray[i] = array1[i] * array2[i];
        }

        Console.WriteLine("Результат перемножения массивов:");
        Console.WriteLine(string.Join(", ", resultArray));
    }

    static void FindMaxMin()
    {
        Console.WriteLine("Введите пять чисел:");
        int[] numbers = new int[5];
        for (int i = 0; i < 5; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int max = numbers[0];
        int min = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max) max = number;
            if (number < min) min = number;
        }

        Console.WriteLine($"Максимальное число: {max}");
        Console.WriteLine($"Минимальное число: {min}");
    }

    static void PrintPyramid()
    {
        Console.WriteLine("Введите количество уровней:");
        int levels = int.Parse(Console.ReadLine());

        for (int i = 1; i <= levels; i++)
        {
            Console.WriteLine(new string(' ', levels - i) + string.Join(" ", Enumerable.Range(1, i)));
        }
    }

    static void PrintMultiplicationTable()
    {
        for (int i = 1; i <= 9; i++)
        {
            for (int j = 1; j <= 9; j++)
            {
                Console.Write($"{i} x {j} = {i * j}\t");
            }
            Console.WriteLine();
        }
    }

    static void DigitOperations()
    {
        Console.WriteLine("Введите целое число:");
        int number = int.Parse(Console.ReadLine());
        int sum = 0, product = 1, temp = number;

        while (temp > 0)
        {
            int digit = temp % 10;
            sum += digit;
            product *= digit;
            temp /= 10;
        }

        Console.WriteLine($"Сумма цифр: {sum}");
        Console.WriteLine($"Произведение цифр: {product}");
    }
}
