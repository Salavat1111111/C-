Console.Clear();

//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.


//Console.WriteLine(" Введите трехзначное  число: ");

//int number = Convert.ToInt32(Console.ReadLine());
//int num1 = number % 100;

//Console.WriteLine(num1);

//int num2 = num1 / 10;
 
//Console.WriteLine(num2);

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//Console.WriteLine(" Введите число: ");

//int num = Convert.ToInt32(Console.ReadLine());

//string text = Convert.ToString(num);

//int i = 2;

//if( text.Length == 2)
//{
//Console.WriteLine(" Третьей цифры нет.");
//}
//else 
//{
   // Console.WriteLine(text[i]);
//}



//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine(" Введите цифру, обозначающую день недели: ");

int num = Convert.ToInt32(Console.ReadLine());

if ( num == 6 ^ num == 7)
{
   Console.WriteLine(" Да!");
}
else 
{
   Console.WriteLine(" Нет!");
}



