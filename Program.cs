//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)
//2, 4 -> 16

//Console.WriteLine("Введите число А");
//int A = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Введите число B");
//int B = Convert.ToInt32(Console.ReadLine());

//int result = A;      // 3 3 3 3 3
//for (int i = 1; i < B; i++)
//{
//result = result * A;     
//}
//Console.WriteLine($"Число {A} в степени {B} = {result}");


//Задача 27: Напишите программу, которая принимает на вход число и 
//выдаёт сумму цифр в числе.

//452 -> 11
//82 -> 10
//9012 -> 12

//Console.WriteLine("Введите число: ");
//int x = Convert.ToInt32(Console.ReadLine());

//int sum = 0;
//while (x >0)
//{
//    sum += x % 10;
//    x /= 10;
//}
//Console.WriteLine($"Сумма цифр в числе {x} = {sum}");


//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и 
//выводит их на экран.

//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]


int[] array = new int[8];
Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(100);   
} 
for (int i = 0; i < array.Length; i++)
{
 Console.Write(array[i]+",");  
}
Console.Write("]");
