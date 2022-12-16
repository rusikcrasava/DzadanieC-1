Console.Write("Введите первое число:");
int Num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:");
int Num2 = Convert.ToInt32(Console.ReadLine());
if (Num1 < Num2)
{
    Console.WriteLine($"Максимальное значение = {Num2} , Минимальное значение = {Num1} ");
}
else
{
    Console.WriteLine($"Минимальное значение = {Num1} , Максимальное значение = {Num2} ");
}
