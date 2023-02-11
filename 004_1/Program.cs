//Задача 25: Напишите функцию, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//Нельзя использовать библиотеку Math!

Console.Clear();
Console.WriteLine("Введите число: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число в натуральную степень которого будем возводить: ");
int num2 = int.Parse(Console.ReadLine()!);

int GetExpo(int x)
{
    int mult = 1;
    for (int b = 1; b <= x; b++) // счетчик от единицы, т.к. натуральная степень
    {
      mult = mult * num1;
    }
    return mult;
}
//Console.WriteLine(string.Join(",", GetExpo)); // вывод массива

Console.WriteLine($"Итоговое число - {GetExpo(num2)}");