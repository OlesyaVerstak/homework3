//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int A = inputNumber();
int result = Sum(A);
System.Console.WriteLine(result);

int Sum(int A)
{
int sum = 0;
    while (A > 0)
    {
        int num = A % 10;
        A = A / 10;
        sum = sum + num;
    }
    return sum;
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
/*Console.WriteLine("введите число");
int i = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (i > 0)
{
int num = i % 10;
i = i / 10;
sum = sum + num;
}
Console.WriteLine("сумма всех цифр в числе равна: " + sum);*/