//Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

int ReadInt(string arg)
{
   System.Console.Write($"Введите число: ");
   return int.Parse(Console.ReadLine());
}

int a = ReadInt("сторона а");
int b = ReadInt("сторона b");
int c = ReadInt("сторона c");

bool IsTriangle (int a, int b, int c)
{
    if ((a + b) > c && (a + c) > b &&  (c + b) > a)
    {
        return true;
    }
    return false;
}

System.Console.WriteLine(IsTriangle(a, b, c));