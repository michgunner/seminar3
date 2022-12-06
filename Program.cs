// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).


void FindCoordinates (int quadrant)
{
   if (quadrant == 1)
      Console.WriteLine("X>0 and Y>0");
   if (quadrant == 2)
      Console.WriteLine("X<0 and Y>0");
   if (quadrant == 3)
      Console.WriteLine("X<0 and Y<0");
   if (quadrant == 4)
      Console.WriteLine("X>0 and Y<0");
}

Console.WriteLine("Please, input quadrant");
int quadrant = Convert.ToInt32(Console.ReadLine());
if (quadrant>0 && quadrant<5)
   FindCoordinates(quadrant);
else
   Console.WriteLine("No coordinates for this quadrant.");



//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.



double CoordinateLength (double x1, double x2, double y1, double y2)
{
   double catet1 = x2 - x1;
   double catet2 = y2 - y1;
   double result = Math.Sqrt(Math.Pow(catet1, 2) + Math.Pow(catet2, 2));
   return result;
}

Console.WriteLine("Please, input X for first dot: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please, input Y for first dot: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please, input X for secound dot: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please, input Y for secound dot: ");
double y2 = Convert.ToDouble(Console.ReadLine());

double result = Math.Round(CoordinateLength(x1, x2, y1, y2), 4);
Console.WriteLine("The result is " + result);


//Напишите программу, которая принимает на вход число (N) и выдаёт ряд квадратов чисел от 1 до N.


void PrintRow(int number)
{
   for (int i = 1; i<=number; i++)
   {
      double square = Math.Pow(i, 2);
      Console.Write(square + " ");
   }
}

Console.WriteLine("Please, write your number: ");
int number = Convert.ToInt32(Console.ReadLine());
PrintRow(number);