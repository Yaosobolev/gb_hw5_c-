/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */

int GetLeinghtArray(string msg){
    int resultLeinght = 0;
    while(true){
        Console.Write(msg);
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

(int,int) GetExhibitor(int[] array){ // Можно было не использовать метод для нахождения max и min
    int max = array[0];//А сразу найти разницу int result = array.Max()-array.Min()
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]>max) max = array[i];
    }
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]<min) min = array[i];
    }
    return (max,min);
}

int GetDif(int max,int min){
    int result = max - min;
    return result;
}

int length = GetLeinghtArray("Введите длину массива: ");
int[] array = GetArray(length);
(int max,int min) = GetExhibitor(array);
int result = GetDif(max,min);
Console.WriteLine($"Разница между max({max}) и min({min}) массива [{string.Join(" ",array)}] = {result}");