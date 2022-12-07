/*

Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125

*/



// Обрабатывает ввод данных, возвращает целое число
int GetNumber()
{
    bool isCorrect = false;
    int number = 0;

    while (!isCorrect)
    {
        Console.Write("Введите целое число: ");
        string input = Console.ReadLine() ?? "";

        if (int.TryParse(input, out number))
        {
            if (number == 0)
                Console.WriteLine("Введите число, отличное от нуля.");
            else
                isCorrect = true;
        }
            
        else
            Console.WriteLine(input.Trim() == "" ? "Вы ничего не ввели" : "Вы ввели некорректные данные");
    }
    
    return number;
}



// Возвращает ряд кубов чисел от 1 до number
string GetСubesRow(int number) 
{
    string cubesRow = "";
    
    for (int i = 1; i <= number; i ++)
    {
        cubesRow += Math.Pow(i, 3);
        if (i != number)
            cubesRow += ", ";
    }

    return cubesRow;
}



int number = GetNumber();
string cubesRow = GetСubesRow(number);

Console.WriteLine($"Таблица кубов чисел: {cubesRow}");