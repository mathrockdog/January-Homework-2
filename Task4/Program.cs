// Дополнительная необязательная задача 37 из семинара.
// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] GetRandomNumbersArray(int arrayLength = 6)
{
    int[] array = new int[arrayLength];
    Random randomNumbers = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = randomNumbers.Next(0, 10);
    }
    return array;
}

int[] GetMultiplicationOfPairsOfNumbers(int[] array)
{
    int[] mult = new int[(array.Length + 1) / 2];
    for (int i = 0; i < (array.Length + 1) / 2; i++)
    {
        if (i != array.Length - 1 - i)
        {
            mult[i] = array[i] * array[array.Length - 1 - i];
        }
        else
        {
            mult[i] = array[i];
        }
    }
    return mult;
}

int[] RandomNumbersArray = GetRandomNumbersArray();
int[] MultiplicationOfPairsOfNumbers = GetMultiplicationOfPairsOfNumbers(RandomNumbersArray);
Console.Write("Произведение пар чисел в массиве [" + string.Join(", ", RandomNumbersArray) + "] равно " + string.Join(", ", MultiplicationOfPairsOfNumbers));