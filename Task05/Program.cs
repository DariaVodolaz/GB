//Задача 10 и 13 (они же похожи)
Console.WriteLine("Введите число:");

string number = Console.ReadLine();

if (number.Length < 3){
    Console.WriteLine("Третьей цифры нет");
}
else{
    Console.WriteLine(number[2]);
}