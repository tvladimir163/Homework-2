Console.Clear();

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// int number = new Random().Next(1, 1000);
// Console.WriteLine($"наше число: {number}");

// if(number > 99)
// {
//     number = number / 10 % 10;
//     Console.WriteLine($"вторая цифра: {number}");
// }

// else if(number > 9)
// {
//     Console.Write($"число {number} двухзначное");
// }

// else
// {
//     Console.Write($"число {number} однозначное");
// }

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if(number > 99)
// {
// number = number % 10;
// Console.Write($"число трехзначное, третья цифра: {number}");
// }

// else if(number > 9)
// {
//         Console.Write($"число {number} двухзначное");
// }

// else
// {
//     Console.Write($"число {number} однозначное");
// }

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// Console.Write("Введите число ");
// int number = Convert.ToInt32(Console.ReadLine());

// if(number == 1)
// {
// 	Console.WriteLine("Будни, понедельник");
// }

// else if (number == 2)
// {
// 	Console.WriteLine("Будни, вторник");
// }

// else if (number == 3)
// {
// 	Console.WriteLine("Будни, среда");
// }

// else if (number == 4)
// {
// 	Console.WriteLine("Будни, четверг");
// }

// else if (number == 5)
// {
// 	Console.WriteLine("Будни, пятница");
// }

// else if (number == 6)
// {
// 	Console.WriteLine("Выходной, суббота");
// }

// else if (number == 7)
// {
// 	Console.WriteLine("Выходной, воскресенье");
// }

// else if (number > 7)
// {
// 	Console.WriteLine("Такого дня недели нету");
// }

// 14. Дополнительная задача. Напишите программу которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

Console.Write("Введите число кратное 7 и 23: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 23 == 0 && number % 7 == 0)
{
    Console.WriteLine($"число {number} кратно 7 и 23");
}
else
{
   Console.WriteLine($"число {number} не кратно 7 и 23"); 
}