//Задача 21

int[] a = new int[3]{3, 6, 8};
int[] b = new int[3]{2, 1, -7};

Console.WriteLine($"Расстояние между точками - {Math.Sqrt(Math.Pow(a[0]-b[0], 2)+Math.Pow(a[1]-b[1], 2)+Math.Pow(a[2]-b[2], 2))}");