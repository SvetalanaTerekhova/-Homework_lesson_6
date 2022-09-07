// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 1 Вариант решения через массив.

/* Console.Write("Сколько цифр Вы хотите ввести: ");
int size = int.Parse(Console.ReadLine());
double[] array = new double[size];
int count = 0;
int number = 1;
for (int i = 0; i < size; i++)
{
    Console.Write($"Введите {number} число: ");
    array[i] = double.Parse(Console.ReadLine());
    if(array[i] > 0) count++;
    number++;
}
Console.Write($"Ответ: среди {size} введенных чисел больше нуля -> {count}"); */

// 2 Вариант решения без массив.

Console.Write("Сколько цифр Вы хотите ввести: ");
int size = int.Parse(Console.ReadLine());
int count = 0;
string resul = " ";
int number1 = 1;

for (int i = 0; i < size; i++)
{
    Console.Write($"Введите {number1} число: ");
    double number = double.Parse(Console.ReadLine());
    resul = resul + number + ",";
    if(number > 0) count++;
    number1++;
}
Console.Write($"Ответ: среди введенных чисел {resul} больше нуля -> {count}");