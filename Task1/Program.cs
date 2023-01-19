// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] GetRandomNumbersArray(int arrayLength = 4)
{
    int[] array = new int[arrayLength];
    Random randomNumbers = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = randomNumbers.Next(100, 1000);
    }
    return array;
}

int GetEvenAmount(int[] numbers)
{
    int counter = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0)
        {
            counter = counter + 1;
        }
    }
    return counter;
}

int[] array = GetRandomNumbersArray(8);

int evenAmount = GetEvenAmount(array);

Console.Write("Количество чётных чисел в массиве [" + string.Join(", ", array) + "] - " + evenAmount);