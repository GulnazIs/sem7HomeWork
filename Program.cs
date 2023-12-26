// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

Console.WriteLine("Введите значения начала(M) и конца(N) промежутка чисел.");
int M = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());

void PrintNums (int startNum, int endNum)
{
    Console.Write(startNum+ " ");
    if (startNum >= endNum)
    {
        return;
    }
    PrintNums (startNum+1,endNum);
}
PrintNums(M,N);

// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.WriteLine("Введите значения m и n для вычисления функции Аккермана.");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int AkkermanFunction (int m, int n)
{
    if (m < 0 || n < 0) {Console.WriteLine("Введите неотрицательные числа.");}
    if (m == 0) { return n+1; }
    if (n == 0) { return AkkermanFunction(m-1,1);}
    else {return AkkermanFunction(m-1,AkkermanFunction(m,n-1));}
}
Console.WriteLine("Функция Аккермана равна "+AkkermanFunction(m,n));

// Задача 3: Задайте произвольный массив. Выведите его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.


Console.WriteLine("Введите размер массива.");
int m = Convert.ToInt32(Console.ReadLine());
int [] array = new int[m];

void CreateArray (int [] array, int i)
{
    if(i >= array.Length) {return;}
    array[i] = new Random().Next(1,10);
    Console.Write(array[i]+" ");
    CreateArray(array, i + 1);
} 
void ReverseArray (int [] array, int index)
{
    if (index < 0) {return;}
    Console.Write(array[index]+" ");
    ReverseArray (array, index-1);
}
CreateArray (array,0);
Console.WriteLine();
ReverseArray(array, array.Length - 1);


