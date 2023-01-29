/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
 Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */


int GetLeinghtArray(string msg){
    int lengthResult = 0;
    while(true){
        Console.Write(msg);
        if(int.TryParse(Console.ReadLine(), out lengthResult)&& lengthResult > 0) break;
        else Console.WriteLine("Введи коректное число");
    }
    return lengthResult;
}

int[] GetArray(int n){
    int[] array = new int[n];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(100,1000);
        
    }
    return array;
}

int GenCount(int[] array){
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]%2==0) count++;
    }
    return count;
}
int length = GetLeinghtArray("Введите длину массива ");
int[] array = GetArray(length);
int count = GenCount(array);
Console.WriteLine($"Кол-во четных числе в массиве [{string.Join(" ",array)}] = {count} ");