Console.Clear();


/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Укажите количество вводимых чисел: ");
int num = Convert.ToInt32(Console.ReadLine());



int[] array(int number)
{
    int[] result = new int[number];

    for (int i = 0; i < result.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1} число: ");
        result[i] = Convert.ToInt32(Console.ReadLine());
    }
    return result;
}

void showArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


void showSum(int[] newArray)
{
    int sum = 0;

    for (int i = 0; i < newArray.Length; i++)
    {
        if (newArray[i] > 0) sum += 1;
    }
    Console.WriteLine($"Количество чисел больше 0 = {sum}");
}




int[] test = array(num);
showArray(test);
Console.WriteLine();
showSum(test);*/



////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////






/*Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.


Console.WriteLine("Введите значение k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());


void findX(int num1, int num2, int num3, int num4)
{

    int x = (num4 - num2) / (num1 - num3);
    int y = num3 * x + num4;
    Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");
}





findX(k1, b1, k2, b2);*/
