// Подготовил Раевский Р.Ю.

// Task 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

/* double[,] CreateRandom2dArray()
{
    Console.Write("Введите число строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите минимальное число: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальное число: ");
    int max = Convert.ToInt32(Console.ReadLine());
    double[,] array = new double[rows, columns];
    
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(min, max + 1) + new Random().NextDouble();
    
    return array;
}

void WriteArray(double[,]array)
{
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

double[,] myArray = CreateRandom2dArray();
WriteArray(myArray);
*/

// Task 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

/* int[,] CreateRandom2dArray()
{
    Console.Write("Введите число строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите минимальное число: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальное число: ");
    int max = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, columns];
    
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(min, max + 1);
    
    return array;
}

void WriteArray(int[,]array)
{
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

void Find(int[,] array, int r, int c)
{
    if(r > array.GetLength(0) || c > array.GetLength(1)) Console.Write("Такого значения нет");
    else Console.WriteLine($"Значение с позицией [{r}, {c}] - {array[r-1,c-1]}");
}

int[,] myArray = CreateRandom2dArray();
WriteArray(myArray);

Console.Write("Введите номер строки: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int col = Convert.ToInt32(Console.ReadLine());

Find(myArray, row, col);
*/

// Task 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

int[,] CreateRandom2dArray()
{
    Console.Write("Введите число строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите минимальное число: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальное число: ");
    int max = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, columns];
    
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(min, max + 1);
    
    return array;
}

void Write2dArray(int[,]array)
{
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

double[] MedNum(int[,] array)
{
    double[] array1 = new double[array.GetLength(1)];
    double sum = 0;
    
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int row = 0; row < array.GetLength(0); row++) 
            sum += array[row,i]; 
                  
        array1[i] = sum / array.GetLength(0); 
        sum = 0;     
    }
    return array1;
}

void Write1dArray(double[]array)
{
    for(int i=0; i<array.Length; i++)
        Console.Write(array[i] + "; ");

    Console.WriteLine();
}

int[,] myArray = CreateRandom2dArray();
Write2dArray(myArray);
double[] array1d = MedNum(myArray);
Console.Write("Среднее арифметическое значений в столбцах равно: ");
Write1dArray(array1d);