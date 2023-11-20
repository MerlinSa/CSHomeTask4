// Задача 2: Задайте массив заполненный случайными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.

Console.WriteLine("Введите размер массива");
int length = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[length];

void FillArrayRandomNumbers(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100, 1000);
    }
}
void PrintArray(int[] numbers)
{
    
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    
    Console.WriteLine();

}

FillArrayRandomNumbers(numbers);
Console.WriteLine("массив: ");
PrintArray(numbers);

int count = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0)
        count++;
}
Console.WriteLine($"всего {numbers.Length} чисел, {count} - чётные");


