// 2. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 	3 -> Среда 
// 5 -> Пятница
System.Console.WriteLine("Введите число от 1 до 7");

int index = int.Parse(Console.ReadLine());

string[] days = { "Понедельник", "Вторник", "среда", "четверг", "пятница", "суббота", "Воскресенье" };


if (index >= 1 && index <= 7)
{
    System.Console.Write(days[index - 1]);
}


else
{
    System.Console.WriteLine("Такого дня недели не существует");
}


