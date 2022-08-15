/* Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/

Console.WriteLine("Введите номер дня недели: ");
int num = Convert.ToInt32(Console.ReadLine());
if ( num == 6 || num ==7)
{
    Console.WriteLine("Поздравляю!Выходной!");
}
if ( num == 1 || num == 2 || num == 3 || num == 4 || num == 5)
{
    Console.WriteLine("Увы( Еще будни");
}
if ( num < 1 || num > 7)
{
    Console.WriteLine("Такого дня в недели нет");
}