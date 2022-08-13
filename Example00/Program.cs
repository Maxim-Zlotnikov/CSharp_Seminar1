// Напишите программу, которая на вход принимает число
// и выдает его квдрат (число, умноженное на само себя).

System.Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

System.Console.WriteLine($"Квадрат числа {number} равен - {number * number}");
System.Console.WriteLine($"Квадрат числа {number} равен - {Math.Pow(number, 2)}");