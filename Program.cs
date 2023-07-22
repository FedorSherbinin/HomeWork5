/*// Task 1.  Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateRandomArray(int size)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(100, 1000);
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int CountArr(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count+=1;
    }
    return count;
}

Console.WriteLine("Input size of array: ");
int length = Convert.ToInt32(Console.ReadLine());

int[]myArray = CreateRandomArray(length);
ShowArray(myArray);
Console.Write("result: ");

int count = CountArr(myArray);
Console.WriteLine(count);
*/

/*// Task 2. Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int SumNumber(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i+=1)
    {
        if(i %2 == 1) sum += array[i];
    }
    return sum;
}

Console.Write("Input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("imput a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, min, max);
int evenSum = SumNumber(myArray);

ShowArray(myArray);
Console.WriteLine("Sum of even indices is " + evenSum);
*/

/*// Task 3. Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] CreateArray(int num)
{
    double[] Array = new double[num];
    for(int i = 0; i < num; i++)
    {
        Array[i] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;
        
    }
    return Array;
}

void ShowArray(double[] array)
{
    Console.Write("[ ");
    for(int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");

    Console.WriteLine("]");
}

double Diff(double[] array)
{
    double min = array[0];
    double max = array[0];
    double result = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if(max < array[i]) max = array[i];
        else if(min > array[i]) min = array[i];
    }

    result = max - min;
    return Math.Round(max - min, 2);

}

Console.Write("Input a length of array: ");
int numbers = Convert.ToInt32(Console.ReadLine());

double[] myArray = CreateArray(numbers);
ShowArray(myArray);
double result = Diff(myArray);

Console.WriteLine($"Difference between max and min elements {result} ");
*/