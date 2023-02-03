// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int GetNum(string text)
{
    Console.Write(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}

double[] IntersectionPoint(int k1, int b1, int k2, int b2)
{
    if (k1 == k2) return null;

    //k1*x+b1=k2*x+b2;
    //k1*x-k2*x=b2-b1;
    //x=(b2-b1)/(k1-k2);

    double[] point = new double[2];
    point[0] = Convert.ToDouble(b2 - b1) / Convert.ToDouble(k1 - k2);
    point[1] = k1 * point[0] + b1;

    return point;
}

int b1 = GetNum("Введите число b1: ");
int k1 = GetNum("Введите число k1: ");
int b2 = GetNum("Введите число b2: ");
int k2 = GetNum("Введите число k2: ");

double[] point = IntersectionPoint(k1, b1, k2, b2);

if (point == null) Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> Прямые параллельны");
else Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> (" + String.Join(", ", point) + ")");