/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
string word = Convert.ToString(num);

if (word.Length > 2)
{
    Console.WriteLine($"3 цифра числа это {word[2]}");
}
else
{
    Console.WriteLine("3 цифры нет");
}