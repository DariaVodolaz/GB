//Задача 8
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

string result = "";

for (int i = 2; i <= number; i+=2){
    if ( i % 2 == 0 ){
        result += $"{i}, ";
    }
}

Console.WriteLine(result.Substring(0, result.Length-2));