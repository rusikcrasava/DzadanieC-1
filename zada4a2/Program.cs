Console.Write("Введите первое число:");
int Number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:");
int Number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число:");
int Number3 = Convert.ToInt32(Console.ReadLine());
if (Number1 > Number2) 
{ 
    if (Number1 > Number3) 
    { 
        Console.WriteLine($"Максимальное значение = {Number1} "); 
    } 
 
} 
else if (Number3 > Number2) 
{ 
    Console.WriteLine($"Максимальное значение = {Number3} "); 
} 
 
else 
{ 
    Console.WriteLine($"Максимальное значение = {Number2} "); 
}