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

*/

