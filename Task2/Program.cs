﻿//  Задача 40: Напишите программу, которая 
// принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой 
// длины.
//  Теорема о неравенстве треугольника: 
// каждая сторона треугольника меньше суммы 
// двух других сторон.


// int Promt(string message)
// {
//   Console.WriteLine(message);
//   int number = Convert.ToInt32(Console.ReadLine());
//   return number;
// }

// int number1 = Promt("Введите первое число: ");
// int number2 = Promt("Введите второе число: ");
// int number3 = Promt("Введите третье число: ");


// if (number1 < number2+number3 && number2 < number1+number3 && number3 < number1+number2)
//   Console.WriteLine($"Треугольник с сторонами {number1}, {number2}, {number3} существует");
// else Console.WriteLine($"Треугольник с сторонами {number1}, {number2}, {number3} не существует");



//  Задача 42: Напишите программу, которая 
// будет преобразовывать десятичное число в двоичное.



string TenToTwo(int num)
{
    string firstResult= " ";
    while(num>0)
{
    string result = Convert.ToString(num%2);
    // result = result + firstResult;
    // firstResult = result;
    firstResult= result + firstResult;
    num /= 2;
}
    return firstResult;
}

Console.WriteLine(TenToTwo(19));



