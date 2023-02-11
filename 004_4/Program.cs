// напишите функцию, которая принимает одно число - высоту елочки и рисует ее в консоли звездочками.

Console.Clear();
Console.WriteLine("Введите число - вершину елочки: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите высоту елоки: ");
int num2 = int.Parse(Console.ReadLine()!);
Console.SetCursorPosition(num1, num2);
Console.WriteLine("+");

int count = 1;//присвоить значение у
int x = num1, y = num2;

while (count > 0 && count <= y)
{ 
  int per = 0;
  Console.SetCursorPosition(x - per, y - per);
  Console.WriteLine("+");
     
  Console.SetCursorPosition(x, y - per);
  Console.WriteLine("+");

  Console.SetCursorPosition(x + per, y - per);
  Console.WriteLine("+");
  count++;
  per++;
  x++;
  y++;
}