/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
 Данные вводятся с консоли пользователем */

 Console.Write("Введите кол-во элементов в массиве:\t");
 int ElementsCount = Convert.ToInt32(Console.ReadLine());// = int Parse(Console.ReadLine());

int [] MyArray =new int[ElementsCount];

  for (int i = 0; i < MyArray.Length; i++)
{
    Console.Write($"\nВведите элемент массива под индексом  {i}: \t");
    MyArray[i]=Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Вывод массива");

for (int i = 0; i < MyArray.Length; i++)
{
    Console.WriteLine(MyArray[i]);
}


