double NumberDegree (int number, int degree)
{

    double result = number;
    for (int i = 1; i < degree; i++)
    {
        result = result * number;
    }
    return result;
}
 Console.WriteLine("Введите число");
 int num = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Введите степень");
 int deg = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine($"число: {num}, степень: {deg} = {NumberDegree(num, deg)}");

