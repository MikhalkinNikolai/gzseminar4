// Напишите программу, которая бесконечно запрашивает целые числа с консоли.
// Программа завершается при вводе символа q или при вводе числа, сумма цифр которого четная.

int Sum(int num){
    if (num < 10)
        return num;
    int digit = num % 10;
    int nextnum = num / 10;
    return digit + Sum(nextnum);
}

void Start(){
    Console.WriteLine("Введите число");
    string stop = Console.ReadLine();
    int num = Convert.ToInt32(Console.ReadLine());
    int result = Sum(num);
    if ( stop == "q" && result % 2 == 0)
        return;
    Start();    
}     


Start();