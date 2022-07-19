//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 


double levelFirst (double argb1, double argk1, double agrb2, double agrk2)
{
    return ((agrb2-argb1) / (argk1-agrk2));

}

double levelSecond (double firsrArgument, double argumentB, double argumentK)
{
    return argumentK * firsrArgument + argumentB;
}

Console.WriteLine("Введите переменные для уравнений y = k1 * x + b1, y = k2 * x + b2;");
Console.Write("k1 = ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("b1 = ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("k2 = ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("b2 = ");
double b2 = Convert.ToDouble(Console.ReadLine());

double x = levelFirst(b1, k1, b2, k2);
double y = levelSecond(x, b1, k1);

Console.WriteLine($"Точка пересечения двух прямых с заданными коэффициентами ( {x} ; {y} )");