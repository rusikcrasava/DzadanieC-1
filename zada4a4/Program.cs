Console.Write("Введите число:");
int Vsechetnye = Convert.ToInt32(Console.ReadLine());
int i = 0;
while (i < Vsechetnye)
{
    i += 2;
    if (i <= Vsechetnye)
    Console.WriteLine(i);
}
Console.WriteLine("Все числа лежащие в данном диапазоне были проверены.");
