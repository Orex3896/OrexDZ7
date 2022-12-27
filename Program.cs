/*
Console.WriteLine("Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.")
void Show2dArray(double[,] array)// метод выводит массив
{
    for(int i =0; i < array.GetLength(0); i++)
    {
        for(int j =0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + "  ");
            
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[,] CreateRandom2DArrayDouble(int n,int m, int minV, int maxV)
{   
    double[,] sum = new double[n,m];
    int[,] array = new int[n,m]; 
    double[,] doubleArray = new double[n,m];
    for(int i = 0;i<n;i++)
    {
        for (int j = 0; j < m; j++)
        {
        array[i,j]= new Random().Next(minV,maxV);
        doubleArray[i,j]= new Random().NextDouble();
        doubleArray[i,j] = Math.Round(doubleArray[i,j],2);//рандомный массив double
        sum[i,j]=array[i,j]+doubleArray[i,j];//Слияние двух массивов int и double
        }
    }
    return sum;
}
    Console.Write("Введите кол-во строк m: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите кол-во столбцов n: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите min элемент: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите max элемент): ");
    int maxValue = Convert.ToInt32(Console.ReadLine());


double[,] myArray = CreateRandom2DArrayDouble(n,m,minValue,maxValue);
Show2dArray(myArray);
*/
/*
Console.WriteLine("Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.");
void Show2dArray(int[,] array)// метод выводит массив
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "\t");

        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] CreateRandom2dArray(int m, int n, int min, int max)// размер массива, минимальное его число и максимальное число
{
    int[,] array = new int[m, n]; //выделили память для двумерного массива
    for (int i = 0; i < m; i++)//идет по столбцам
        for (int j = 0; j < n; j++)//идёт по строкам
            array[i, j] = new Random().Next(min, max);//рандомно заполняем массив

    return array;
}

void ToLookForElements(int[,] array, int a, int b)
{
    if (a > array.GetLength(0) && b > array.GetLength(1))
      Console.WriteLine("такого числа нет, т.к. вышли за рамки массива");
    else
    {
      object c = array.GetValue(a, b);//возвращает значение поля в котором мы находимся
      Console.WriteLine($"значение элемента под индексом {a} , {b} = {c}");
    }
}

Console.Write("Введите кол-во строк m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите min элемент: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите max элемент): ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, minValue, maxValue);
Show2dArray(myArray);

Console.WriteLine("Введите координаты");
Console.WriteLine("Введите элемент *a* который нужно найти: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите элемент *b* который нужно найти: ");
int B = Convert.ToInt32(Console.ReadLine());

ToLookForElements(myArray, A, B);
*/
Console.WriteLine("Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.Например, задан массив:");
void Show2dArray(int[,] array)// метод выводит массив
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "\t");

        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] CreateRandom2dArray(int m, int n, int min, int max)// размер массива, минимальное его число и максимальное число
{
    int[,] array = new int[m, n]; //выделили память для двумерного массива
    for (int i = 0; i < m; i++)//идет по столбцам
        for (int j = 0; j < n; j++)//идёт по строкам
            array[i, j] = new Random().Next(min, max);//рандомно заполняем массив

    return array;
}
double SredneeArifmStolbcov(int[,] array)
{
 double sum=0;
  double[] result= new double[array.GetLength(1)];//создаю одномерный массив 
  for(int j=0;j<array.GetLength(1);j++)//прохожусь по стобцам
  {
    for (int i = 0; i < array.GetLength(0); i++)// прохожусь по строкам
    {
      sum+=array[i,j];
    }
    sum/=array.GetLength(1);
    Console.WriteLine($"среднее арифмитическое столбца № {j+1} = {Math.Round(sum,2)}");
    sum=0;//обнуляю сумму для следующего столбца
  }
  return sum;
}

Console.Write("Введите кол-во строк m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите min элемент: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите max элемент): ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, minValue, maxValue);
Show2dArray(myArray);
SredneeArifmStolbcov(myArray);

