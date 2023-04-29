//Задача 2
Console.WriteLine("Введите первое число:");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber)
Console.WriteLine($"Большее - {firstNumber}, меньшее - {secondNumber}");
else
Console.WriteLine($"Большее - {secondNumber}, меньшее - {firstNumber}");