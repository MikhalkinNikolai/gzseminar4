// Задайте массив заполненный случайными трехзначными числами.
// Напишите программу, которая покажет количество четных чисел в массиве.

int [] CreateArray(int min, int max, int size){
    int [] array = new int [size];
    for(int i = 0; i < size; i++){
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void ShowArray(int [] array){
    for(int i = 0; i < array.Length; i++){
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void Tesk2(int [] array){
    int num = 0;
    for(int i = 0; i < array.Length; i++){
        if( array[i] % 2 == 0){
            num++;
        }
    }
    Console.WriteLine($"В данном массиве {num} четных чисел");
}

Console.WriteLine("Введите длинну массива");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное число массива");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное число массива");
int max = Convert.ToInt32(Console.ReadLine());

int [] array = CreateArray(min, max, size);

ShowArray(array);
Tesk2(array);
