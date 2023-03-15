//  Решение в группах задач:
//  Задача 44: Не используя рекурсию, 
// выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
//  Если N = 5 -> 0 1 1 2 3
//  Если N = 3 -> 0 1 1
//  Если N = 7 -> 0 1 1 2 3 5 8
//   Задача 45: Напишите программу, 
// которая будет создавать копию заданного 
// массива с помощью поэлементного копирования.


int [] Nfibonacci (int num)
{
    int [] array = new int[num];
    int a = 0;
    int b = 1;
    array[0]=a;
    array[1]=b;
    for (int i =2; i <num; i++)
        {
            array[i] = a+b;
            a = b;
            b = array[i];
        }
    return array;
}

Console.WriteLine(String.Join(" ", Nfibonacci(8)));

//Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного копирования

int [] ArrayCopy (int [] array)
{
    int [] newArray = new int[array.Length];
    for(int i = 0; i < array.Length; i++)
    {
        newArray[i] = array[i];
    }
    return newArray;
}


int[] array = ArrayFillInt(5);
Console.WriteLine(String.Join(" ", array));
Console.WriteLine(String.Join(" ", ArrayCopy(array)));

