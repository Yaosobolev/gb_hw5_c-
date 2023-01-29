/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0 */

int GetLeinghtArray(string msg){
    int resultLeinght = 0;
    while(true){
        Console.WriteLine(msg);
        if(int.TryParse(Console.ReadLine(), out resultLeinght)&&resultLeinght>0) break;
        else Console.WriteLine("Введите коректное число!");
    }
    return resultLeinght;
}

int[] GetArray(int length){
    int[] array = new int [length];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i]=rand.Next(0,100);
    }
    return array;
}

int GetSumArray(int[] array){
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(i%2!=0) sum+=array[i];
    }
    return sum;
}

int length = GetLeinghtArray("Введите длину массива: ");
int[] array = GetArray(length);
int sum = GetSumArray(array);
Console.WriteLine($"Сумма нечетных элементов масива [{string.Join(" ", array)}] = {sum}");
