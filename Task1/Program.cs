// // Задача 39: Напишите программу, которая
//  перевернёт одномерный массив (последний 
//  элемент будет на первом месте, а первый - 
//  на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]


int[] Arr(int arraySize)
{
    int [] randarray = new int[arraySize];
    for (int i = 0; i < randarray.Length; i++)
    {
        randarray[i] = new Random().Next(1, 21);
    }
    return randarray;

}

int Promt()
{
    Console.WriteLine(("Ведите количество эллементов массива: "));
    return Convert.ToInt32(Console.ReadLine());
}

int [] forseArr = Arr(Promt());

int[] Mirarr (int [] forseArr)
{
    for (int i = 0; i < forseArr.Length/2; i++)
    {
        int prm = forseArr[i];
        forseArr[i]= forseArr[forseArr.Length -1-i];
        forseArr[forseArr.Length -1-i]=prm;
    } 

    return forseArr;
}

Console.WriteLine();
Console.WriteLine($"Наш массив: [{String.Join("; ", forseArr)}]");
Console.WriteLine();
Console.WriteLine($"Наш массив: [{String.Join("; ", Mirarr(forseArr))}]");
Console.WriteLine();


