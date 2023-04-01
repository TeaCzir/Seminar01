//Из двух на вход, какое максимальное.
Console.Clear();
Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
if(number1 > number2)
{
   Console.Write("первое число максимальное.");
}
if(number1 < number2)
{
   Console.Write("второе число максимальное.");
}
if(number1 == number2)
{
   Console.Write("Оба числа одинаковые. ");
}