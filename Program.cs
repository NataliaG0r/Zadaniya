
// Задача 10: Напишите программу,
//  которая принимает на вход трёхзначное число
//   и на выходе показывает вторую цифру этого числа.

// // 456 -> 5
// // 782 -> 8
// // 918 -> 1


// System.Console.WriteLine("Введите число");
// int a = Convert.ToInt32(Console.ReadLine());


// if ((Math.Abs(a)) > 100)
// {
//     int b;
// b = (a / 10) % 10;
// System.Console.WriteLine(b);
// }
// else {
//     System.Console.WriteLine(" число не трёхзначное");
// }



// // Задача 13: Напишите программу, 
// которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// // 645 -> 5

// // 78 -> третьей цифры нет

// // 32679 -> 6

System.Console.WriteLine("Введите число");

string chislo = Console.ReadLine();

int length = chislo.Length;

int number = Convert.ToInt32(Console.ReadLine());

if (length > 3)
{
    int stepen = length-3;

    double third = (number/Math.Pow(10, stepen))%10;

}
else if (length ==3) double third = number%10;

else System.Console.WriteLine($"В числе {chislo} третьей цифры нет");




// // Задача 15: Напишите программу,
//  которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

