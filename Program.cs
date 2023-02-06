
// Задача 10: Напишите программу,
//  которая принимает на вход трёхзначное число
//   и на выходе показывает вторую цифру этого числа.

// // 456 -> 5
// // 782 -> 8
// // 918 -> 1


System.Console.WriteLine("Введите число");
 int a = Convert.ToInt32(Console.ReadLine());


if ((Math.Abs(a)) > 100)
 {
    int b;
 b = (a / 10) % 10;
 System.Console.WriteLine(b);
 }
 else {
    System.Console.WriteLine(" число не трёхзначное");
 }



// // Задача 13: Напишите программу, 
// которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// // 645 -> 5

// // 78 -> третьей цифры нет

// // 32679 -> 6



System.Console.WriteLine("Введите число");
int numb = Convert.ToInt32(Console.ReadLine());
 
if (numb<100) 
System.Console.WriteLine("В числе нет третьего знака"); 

else
 {
     while (numb>999)
{
numb = numb/10;
 }
 int third=numb%10;
 System.Console.WriteLine(third);};


// // Задача 15: Напишите программу,
//  которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.WriteLine("Введите цифру, обозначающую день недели");
 int day = Convert.ToInt32(Console.ReadLine());
 if (day>=1&&day<=7)
 {  if(day==1) System.Console.WriteLine("понедельник");
 if(day==2) System.Console.WriteLine("вторник");
 if(day==3) System.Console.WriteLine("среда");
if(day==4) System.Console.WriteLine("четверг");
if(day==5) System.Console.WriteLine("пятница");
if(day==6) System.Console.WriteLine("суббота");
if(day==7) System.Console.WriteLine("воскресенье");
 }
 else
 System.Console.WriteLine("Такого дня недели не существует");
