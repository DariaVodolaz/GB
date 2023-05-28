// Задача 29
int[] GenerateArray(int length, int min, int max){
    int[] result = new int[length];

    for (int i = 0; i < length; i++){
        Random rand = new Random();
        result[i] = rand.Next(min, max);
    }

    return result;
}

int[] arr = GenerateArray(5, 0, 10);

for (int i = 0; i < arr.Length; i++){
    Console.Write($"{arr[i]}, ");
}