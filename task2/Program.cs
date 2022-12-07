/*

Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53

*/



int GetCoord(string coordName)
{
    bool isCorrect = false;
    int coordValue = 0;

    while (!isCorrect)
    {
        Console.Write($"Введите координату {coordName}: ");
        string input = Console.ReadLine() ?? "";
        
        if (int.TryParse(input, out coordValue))
            isCorrect = true;
            
        else
            Console.WriteLine(input.Trim() == "" ? "Вы ничего не ввели" : "Вы ввели некорректные данные");
    }
    
    return coordValue;
}



double GetDistance(int x1, int y1, int z1, int x2, int y2, int z2) 
{
    double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));

    return Math.Round(distance, 2);
}



int x1 = GetCoord("X первой точки");
int y1 = GetCoord("Y первой точки");
int z1 = GetCoord("Z первой точки");
int x2 = GetCoord("X второй точки");
int y2 = GetCoord("Y второй точки");
int z2 = GetCoord("Z второй точки");

double distance = GetDistance(x1, y1, z1, x2, y2, z2);

Console.WriteLine($"Расстояние между точками ({x1}, {y1}, {z1}) и ({x2}, {y2}, {z2}): {distance}");