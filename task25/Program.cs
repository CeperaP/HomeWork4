/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
Не использовать Math.Pow() и аналоги!

 */

 int ReadNumber(string message)
 {
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
 }

int Numb1 =ReadNumber($"Введите 1-е число больше нуля :/t");
int Numb2 =ReadNumber($"Введите 2-е число больше нуля, являющееся степенью 1-го числа :/t");

int NumbEnd=1;
for (int i = 0; i < Numb2; i++)
{
    NumbEnd = NumbEnd*Numb1;

}

Console.WriteLine($"Вывод числа:{NumbEnd}");
