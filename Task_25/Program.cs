/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

using System.Runtime.InteropServices;

int InPut(string message, int size)
{
    int[] array = new int[size];
    System.Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int convert = Convert.ToInt32(Console.ReadLine());
int length_of_number = InPut("Enter the length of the number: ", convert);
string number = InPut("Enter the number: ");

int Sum(int length_of_number)
{

    for(int i = 0; i < length_of_number; i++)
    {
        convert = Convert.ToInt32(number[i]);
        number += convert;
        i++;
    }
    return number;
}
System.Console.WriteLine(Sum(number0));








