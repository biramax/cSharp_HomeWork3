/*

Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да

*/



// Проверяет введённые данные и возвращает корректное /*пятизначное*/ число
int GetNumberFromInput() 
{
    bool isCorrect = false;
    int number = 0;

    while (!isCorrect) 
    {
        Console.Write("Введите натуральное число: ");
        string input = Console.ReadLine() ?? "";

        if (int.TryParse(input, out number)) 
        {
            //if (number < 10000 || number > 99999)
            //    Console.WriteLine("Вы ввели не пятизначное число");

            //else
                isCorrect = true;
        }

        else 
            Console.WriteLine(input.Trim() == "" ? "Вы ничего не ввели" : "Вы ввели некорректные данные");
    }
    
    return Math.Abs(number);
}



// Проверяет, является ли пятизначное число полиндромом
bool CheckIfPolindrom_fiveDigits(int number)
{
    if (number / 10000 != number % 10) // Проверяем равенство 1-го и 5-го числа
        return false;
    
    if (number / 1000 % 10 != number / 10 % 10) // Проверяем равенство 2-го и 4-го числа
        return false;

    return true;
}



// Проверяет, является ли ЛЮБОЕ число полиндромом
bool CheckIfPolindrom_anyNumber(int number)
{
    // Находим разрядность числа
    int length = 0;
    int n = number;
    
    while (n > 0)
    {
        n = n / 10;
        length ++;
    }

    // Проверяем равенство 1-го и последнего числа
    int leftNumber  = number / Convert.ToInt32(Math.Pow(10, length - 1));
    int rightNumber = number % 10;

    if (leftNumber != rightNumber)
        return false;

    // Проверяем на равенство других пар чисел
    for (int i = 1; i < length / 2; i ++)
    {
        leftNumber  = number / Convert.ToInt32(Math.Pow(10, length - 1 - i)) % 10;
        rightNumber = number / Convert.ToInt32(Math.Pow(10, i)) % 10;
                
        if (leftNumber != rightNumber)
            return false;
    }
    
    return true;
}



int number = GetNumberFromInput();

Console.WriteLine("Введённое число "+(CheckIfPolindrom_anyNumber(number) ? "является" : "не является")+" полиндромом.");