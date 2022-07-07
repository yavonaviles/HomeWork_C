/*

// 1. программа, которая на код принимает число, и выдает его квадрат
Console.WriteLine("Input integer numbers: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = num * num;
Console.WriteLine("Result is " + result);



// 2. программа, котоая на вход принимает два числа и проверяет, является ли первое число квадратом второго
Console.Write("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int square = num2 * num2;
if (num1 == square)
Console.WriteLine("First number is square of second number");
else
    Console.WriteLine("First number is not a square of second number");

    

    // напишите программу, которая будет выдавать название дней недели по заданному номеру

    Console.Write("Input number of the day: ");
    int day = Convert.ToInt32(Console.ReadLine());

    if (day < 1 || day > 7){
 Console.Write("Incorrect number");
    }
    else{ 
         if (day == 1){
          Console.Write("Monday");
        } 
        if (day == 2){
        Console.Write("Tuesday");
        }
    }

    

    // 4. программа, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
int current = -1 * num;
while (current <= num){
    Console.WriteLine(current + " ");
    current++;
}



// ДЗ 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ввод двух чисел, программа выдаст большее из них");
        int a, b;
        Console.WriteLine("First number - ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Second number - ");
        b = Convert.ToInt32(Console.ReadLine());
        if (a > b)
        {
            Console.Write("a");
        }
        else
     if (b > a)
        {
            Console.Write("b");
        }
    }
}



// ДЗ 2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел


internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ввод трех чисел, программа выдаст большее из них");
        int num1, num2, num3, max;
        Console.WriteLine("First number - ");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Second number - ");
        num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Third number - ");
        num3 = Convert.ToInt32(Console.ReadLine());
        if (num1 > num2)
        {
            max = num1;
        }
        else
        {
            max = num2;
        }
        if (max > num3)
        {
            Console.Write(max);
            return;
        }
        max = num3;
        Console.WriteLine(max);
    }
}


// ДЗ 3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Input number ");
        int num = Convert.ToInt32(Console.ReadLine());
        int result = num / 2;
        Console.WriteLine("Result is " + result);
    }
}



// ДЗ 4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Input number ");
        int num = Convert.ToInt32(Console.ReadLine());
for (int x = num; x >= 1; x--){   
if (x%2==0)
Console.WriteLine(x);
}



// ДЗ ВТОРОЙ СЕМИНАР. 1 ЗАДАЧА. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
void secondNumber()
{   int num3 = num / 10 % 10;
    Console.WriteLine(num + " -> " + num3);
}
secondNumber();


// 2 ЗАДАЧА. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
void thirdNumber(){
    if (num > 99){
        int current = num;
        while (current > 999){
            current = current / 10;
        }
        int thirdNumber = current % 10;
        Console.WriteLine(num + " -> " + thirdNumber);
    }
    else {
        Console.WriteLine(num + "-> Третьей цифры нет");
    }
}
thirdNumber();



// 3 ЗАДАЧА. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

 Console.Write("Input number of the day: ");
    int day = Convert.ToInt32(Console.ReadLine());

    if (day < 1 || day > 7){
 Console.Write("Incorrect number");
    }
    else{ 
         if (day == 1){
          Console.Write("Не выходной");
        } 
        if (day == 2){
        Console.Write("Не выходной");
        }
        if (day == 3){
        Console.Write("Не выходной");
        }
        if (day == 4){
        Console.Write("Не выходной");
        }
        if (day == 5){
        Console.Write("Не выходной");
        }
        if (day == 6){
        Console.Write("Выходной");
        }
        if (day == 7){
        Console.Write("Выходной");
        }
    }

    
    
    // ДЗ 3. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

internal class Program
{
    private const int V = 100000;

    private static void Main(string[] args)
    {
        void palindrom()
        {
           
            Console.Write("Введите пятизначное число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int num1 = number / 10000 % 10;
            int num2 = number / 1000 % 10;
            int rev1 = number / 10 % 10;
            int rev2 = number % 10;
            int nul = number / 10000;

            if (nul < 1 || nul > 9)
            {
                Console.WriteLine(number + " -> " + "Не пятизначное число");
            }
            else if (num1 == rev2 && num2 == rev1)
            {
                Console.WriteLine(number + " -> " + "Палиндром");
            }
            else
            {
                Console.WriteLine(number + " -> " + "Не палиндром");
            }
        }
        for (int i = 0; i < 10; i++)
        {
            palindrom();
        }
    }
}


// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Input number: ");
int N = Convert.ToInt32(Console.ReadLine());
void cube(){
    int num = 1;
    while(num <= N){
        int result = num * num * num;
        Console.Write( result + " " );
        num++;
    }
}
cube(); 



// ДЗ 4. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

void NumDegree(int first, int second)
{   
    int result = 1;
    for (int i = 0; i < second; i++)
    {
        result = result * first;
    }
    Console.Write(first + "," + second + "->" + " " + result + " ");
}
Console.WriteLine("Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число В(степень): ");
int B = Convert.ToInt32(Console.ReadLine());
NumDegree(A, B);

// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Введите число: ");
 int a = int.Parse(Console.ReadLine());
            int sum = 0;
            while (a > 0)
            {
 
                sum = sum + a % 10;
                a = a /10 ;
 
            }
 Console.WriteLine(sum);

// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

   int[] CreateRandomArray(int size)
        {
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = new Random().Next(1,9);
            }
            return array;
        }

        void ShowArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                 Console.Write(array[i] + " ");
            }
        }

        int[] myArray = CreateRandomArray(8);
        ShowArray(myArray);
        Console.Write(" -> [");
        ShowArray(myArray); 
        Console.WriteLine("]");
         */