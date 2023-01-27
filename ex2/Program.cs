/* Напишите программу, которая найдёт точку пересечения 
двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2
 задаются пользователем. */
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.Clear();
Console.WriteLine("vvedite b1 k1 b2 k2");
string [] f = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
double b1 = double.Parse(f[0]);
double k1 = double.Parse(f[1]);
double b2 = double.Parse(f[2]);
double k2 = double.Parse(f[3]);
Console.WriteLine(String.Join(" ", FinPoint(b1, k1, b2, k2)));
double [] FindPoint(double x1, double y1, double x2, double y2)
{
    double[] crosspoint = new double[2];
    crosspoint[0] = (x2 - x1) / (y2 - y1);
    crosspoint[1] = y1 * crosspoint[0] + x1;
    return crosspoint;
}
