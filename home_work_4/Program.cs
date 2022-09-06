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


/* 27. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.*/


Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());


int Sam ( int A)
{
    string text = Convert.ToString(A);
    string tetx1 = string.Empty;

     for( int i = 0; i <= text.Length; i++)
     {
        tetx1 = tetx1 + text[i];
     }
      
      int M = int.Parse(tetx1);
      return M;
}
 
 int M = Sam(num);
 Console.WriteLine(M);
