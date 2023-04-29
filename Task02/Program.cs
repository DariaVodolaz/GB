//Задача 4
Console.WriteLine("Введите первое число:");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число:");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber){
    if (firstNumber > thirdNumber){
        Console.WriteLine($"Большее - {firstNumber}");
    }
    else{
        Console.WriteLine($"Большее - {secondNumber}");
    }
}
else{
    if (secondNumber > thirdNumber){
        Console.WriteLine($"Большее - {secondNumber}");
    }
    else{
        Console.WriteLine($"Большее - {thirdNumber}");
    }
}