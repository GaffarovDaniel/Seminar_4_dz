using System.Xml.XPath;

int SumDigitNumber (int number)
{
    int result = 0;
    while(number != 0)
    {
        result += (number % 10);
        number /= 10;
    }
    return result;
}

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{num} -> {SumDigitNumber(num)}");
