/*Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

void InPut(string message, int size, int left, int right)
{

    System.Console.WriteLine(message);
    int[] array = new int[size];
    int number = Convert.ToInt32(Console.ReadLine());
}
int number0 = InPut("Enter the lenght of the array: ");
int number1 = InPut("Enter the second number: ");

int[] Sum()
{
    Random rand = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array[index] = rand.Next(left, right);
    }
    return result;
}
System.Console.WriteLine(Sum(number0));