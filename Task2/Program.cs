// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на чётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] GetRandomNumbersArray(int arrayLength = 4)
{
    int[] array = new int[arrayLength];
    Random randomNumbers = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = randomNumbers.Next(-100, 100);
    }
    return array;
}

int GetSumEvenPositionNumbers(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i = i + 2)
    {
        sum = sum + array[i];
    }
    return sum;
}

int[] randomNumbersArray = GetRandomNumbersArray();
int sumEvenPositionNumbers = GetSumEvenPositionNumbers(randomNumbersArray);
Console.Write("Сумма элементов массива [" + string.Join(", ", randomNumbersArray) + "], стоящих на чётных позициях равна " + sumEvenPositionNumbers);