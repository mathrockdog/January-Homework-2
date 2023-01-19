// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int[] GetRandomNumbersArray(int arrayLength = 5)
{
    int[] array = new int[arrayLength];
    Random randomNumbers = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = randomNumbers.Next(-100, 100);
    }
    return array;
}

int GetDiffBetwMinMaxRealNumbers(int[] array)
{
    int min = array[0];
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max - min;
}

int[] randomNumbersArray = GetRandomNumbersArray();
int diffBetwMinMaxRealNumbers = GetDiffBetwMinMaxRealNumbers(randomNumbersArray);
Console.Write("Разница между минимальным и максимальным значениями массива [" + string.Join(", ", randomNumbersArray) + "] равна " + diffBetwMinMaxRealNumbers);