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


// int [] Nfibonacci (int num)
// {
//     int [] array = new int[num];
//     int a = 0;
//     int b = 1;
//     array[0]=a;
//     array[1]=b;
//     for (int i =2; i <num; i++)
//         {
//             array[i] = a+b;
//             a = b;
//             b = array[i];
//         }
//     return array;
// }

// Console.WriteLine(String.Join(" ", Nfibonacci(8)));

//Напишите программу, которая будет создавать
// копию заданного массива с помощью 
// поэлементного копирования

int[] Arr(int arraySize)
{
    int [] randarray = new int[arraySize];
    for (int i = 0; i < randarray.Length; i++)
    {
        randarray[i] = new Random().Next(1, 21);
    }
    return randarray;
}


int [] ArrayCopy (int [] aRray)
{
    int [] newArray = new int[aRray.Length];
    for(int i = 0; i < aRray.Length; i++)
    {
        newArray[i] = aRray[i];
    }
    return newArray;
}

int[] aRray = Arr(5);
Console.WriteLine(String.Join(" ", aRray));
Console.WriteLine(String.Join(" ", ArrayCopy(aRray)));


