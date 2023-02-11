// Задача 27. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Clear();
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма всех цифр в числе {GetSum(num)}");

int GetSum(int x)
{
int summ = 0;
int a = 0;
while (num > 0)
    {
    a = num % 10;
    summ = summ + a; //summ += a - могу написать так, но VS выдает ошибку сборки, не указывая какую и вылетает
    num = num / 10;
    }
return summ;
}


