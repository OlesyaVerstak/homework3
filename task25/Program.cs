// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int A = inputNumber();
int B = inputNumber();
int result = Step(A,B);
System.Console.WriteLine(result);

int Step(int A, int B)
{
    int result = 1;
    for (int i = 1; i <= B; i++)
    {
        result = result*A;
    }

    return result;
}

int inputNumber()
{
    int number;
    string text;

    while (true)
    {
        Console.Write("Введите число: ");
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }
        Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
    }
    return number;
}
/*Console.WriteLine("введите число A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число B");
int b = Convert.ToInt32(Console.ReadLine());
int step = a;

for (int i = 1; i < b; i++)
{
step = step * a;
}
Console.WriteLine("A в степени B равно: " + step);*/