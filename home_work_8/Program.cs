Console.Clear();

/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.WriteLine("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите нижнюю границу диапазона массива: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите вехнюю границу диапазона массива: ");
int max = Convert.ToInt32(Console.ReadLine());


int[,] newArray(int num1, int num2, int minValue, int maxValue)
{
    int[,] result = new int[num1, num2];

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return result;

}

void showArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
}


int[,] firstArray = newArray(m, n, min, max);



for (int i = 0; i < firstArray.GetLength(0); i++)
{
    for (int j = 0; j < firstArray.GetLength(1); j++)
    {
        for (int k = 0; k < firstArray.GetLength(1) - 1; k++)
        {
            if (firstArray[i, k] < firstArray[i, k + 1])
            {
                int num = 0;
                int num3 = firstArray[i, k];
                firstArray[i, k] = firstArray[i, k + 1];
                firstArray[i, k + 1] = num3;
            }
        }
    }
}




Console.WriteLine();
showArray(firstArray);*/


///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


/*Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int n = 3;
int m = 6;

int[,] secondArray(int num1, int num2, int minValue, int maxValue)
{
    int[,] result = new int[num1, num2];

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }

    return result;

}

void showArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int [,] array2 = secondArray(m, n, 1, 10);


int sum = Int32.MaxValue;
int nextStep = 0;

for (int i= 0; i < array2.GetLength(0); i++)
{
    int minSum = 0;
    for ( int j = 0; j < array2.GetLength(1); j++)
    {
           minSum += array2[i, j];
    }
    if (minSum < sum )
    {
        sum = minSum;
        nextStep++;
    }
}

showArray(array2);
Console.WriteLine();
Console.WriteLine($"ноиер строки с минимальной суммой: {nextStep},  сумма = {sum}");*/


