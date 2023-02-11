// Задача 29. напишите программу котороая задает массив из 8 элементов и выводит их на экран.
Console.Clear();
Console.WriteLine("Введите числа массива: ");

int[] ReadMass()
{
    int[] result = new int[8];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = int.Parse(Console.ReadLine()!);
    }
    return result;
}

void PrintMass(int[] array) ///вернуть массив
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}
int[] array = ReadMass();
PrintMass(array);

// второй вариант заполнения массива Рандомно
//но у меня периодически массив заполняется одинаковыми цифрами и я не могу понять почему 

//Console.Clear();

//int[] Mass = new int[8];
//int Rand = new Random().Next();

//for (int i = 0; i < Mass.Length; i++)
//{
//  Mass[i] = Rand;
//}
//return Mass;

//Console.WriteLine(string.Join(",", Mass));