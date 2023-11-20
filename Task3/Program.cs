//Задача 3: Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)

Console.WriteLine("Введите размер массива");
int length = Convert.ToInt32(Console.ReadLine());
Random rand = new Random();
int[] array = new int[length];
int n = array.Length;

for (int i = 0; i < n; i++)
{
    array[i] = rand.Next(10, 100);
    Console.Write($"{array[i]} ");
}
Console.WriteLine();

for (int i = 0; i < n / 2; i++)
{
    int temp = array[i];
    array[i] = array[n - 1 - i];
    array[n - 1 - i] = temp;

}
Console.WriteLine(string.Join(" ", array));
