//Task 1
Console.WriteLine("*1. Нахождение максимального из двух чисел*");

Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
int max = 0;

if (a > b)
{
    max = a;
}
else
{
    max = b;
}
Console.WriteLine("Максимально число: " + max);

//Task 2
Console.WriteLine("*2. Нахождение максимального из трех чисел*");

Console.WriteLine("Введите первое число: ");
int c = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int d = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье  число: ");
int e = int.Parse(Console.ReadLine());
int max_1 = 0;

if (c > d)
{
    max_1 = c;
}
else if (d > e)
{
    max_1 = d;
}
else if (c > e)
{
    max_1 = c;
}
else if (e > c)
{
    max_1 = e;
}
Console.WriteLine("Максимальное число: " + max_1);

//Task 3
Console.WriteLine("*3. Определение четности числа*");
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine($"Число {number} - чётное!");
}
else
{
    Console.WriteLine($"Число {number} - НЕчётное!");
}

//Task 4
Console.WriteLine("*4. Нахождение всех четных введенного числа*");
Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());
int i = 2;

while (i <= N)
{
    Console.Write($"{i}, ");
    i += 2;
}

//Task 5
Console.WriteLine("Введите число дня: ");
int numberDayOfWeek = Convert.ToInt32(Console.ReadLine());

switch (numberDayOfWeek)
{
    case 1: Console.WriteLine("Понедельник"); break;
    case 2: Console.WriteLine("Вторник"); break;
    case 3: Console.WriteLine("Среда"); break;
    case 4: Console.WriteLine("Четверг"); break;
    case 5: Console.WriteLine("Пятница"); break;
    case 6: Console.WriteLine("Суббота"); break;
    case 7: Console.WriteLine("Воскресенье"); break;
    default: Console.WriteLine("Введен неправильное число"); break;
}

//Task 6
Console.WriteLine("Введите первое число");
string input1 = Console.ReadLine();
Console.WriteLine("Введите второе число: ");
string input2 = Console.ReadLine();
if ((Convert.ToInt32(input2) * Convert.ToInt32(input2)) == Convert.ToInt32(input1))
{
    Console.WriteLine($"Да, число {input2} является квадратом числа {input1}");
}
else
{
    Console.WriteLine($"Нет, число {input2} НЕ является квадратом числа {input1}");
}

//Факториал
Console.WriteLine("Введите число, факториал которого необходимо найти");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"Ваше число: {n}");

double Factorial(int n)
{
    if (n == 1) return 1;
    else return n * Factorial(n - 1);
}
Console.WriteLine($"Факториал числа {n} = {Factorial(n)}");