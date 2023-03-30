//Трехзначное на вход, на выход последнее.
Console.Clear();
Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());
while(number<100||number>999)
{
 Console.WriteLine("Введено неверное значение:");
 Console.Write("Введите трехзначное число: ");
 number = int.Parse(Console.ReadLine());
}
int y = number%10;
Console.Write("Последняя цифра: ..");
Console.Write($"{y}");