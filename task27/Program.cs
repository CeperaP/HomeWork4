// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Digits (int value)
{
    int result=0;
    
    while (value > 0)
{
    result += value % 10;
    value = value/10;
   
}
 return result;

}


int number= ReadNumber("Введите число");
int Finish = Digits(number);
Console.WriteLine(Finish);