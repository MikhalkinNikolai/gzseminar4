// Напишите программу, которая перевернет одномерный массив.

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

int [] Revers(int [] array){
    int [] array1 = new int [array.Length];
    int length = array.Length;
    for(int i = 0; i < length; i++){
        array1[i] = array[array.Length - 1 - i];
    }
    return array1;
}

Console.WriteLine("Введите длинну массива");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное число массива");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное число массива");
int max = Convert.ToInt32(Console.ReadLine());

int [] array = CreateArray(min, max, size);

int [] array1 = Revers(array);

ShowArray(array);
ShowArray(array1);