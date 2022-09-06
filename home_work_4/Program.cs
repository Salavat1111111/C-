/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 


Console.WriteLine("введите число A");
int Z = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите число B");
int C = Convert.ToInt32(Console.ReadLine());

int Multiply ( int A, int B)
{
   int num = 1;
       for ( int i = 1; i <= B; i++)
          {
             if ( B != 1) num = num * A;
            else num = A;
          }
  
  return num;
    
}

int N = Multiply (Z, C);

Console.WriteLine(N); */

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

/* 27. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());


int Sum ( int A)
{
    int num1 = 0;

    for ( int i = A; i > 0; i/=10)
    {
      num1 = num1 + i % 10;
    }
    return num1;
}
 
 int M = Sum(num);
 Console.WriteLine(M);*/



////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


