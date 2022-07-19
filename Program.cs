// void Zadacha19 () {
// Console.WriteLine("Введите число:");
// int num = Convert.ToInt32(Console.ReadLine.Next());
// if (num >= 10000 && num <= 9999) 
// num %= 10;

// }
// Zadacha19();

void Zadacha21 () {
int ind = 999, count = 0;
while(ind > count) 
{
    double dist;
    Console.WriteLine("Введите координаты x, y, z точки A: ");
    int xA = Convert.ToInt32(Console.ReadLine()),
    yA = Convert.ToInt32(Console.ReadLine()),
    zA = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координаты x, y, z точки B: ");
    int xB = Convert.ToInt32(Console.ReadLine()),
    yB = Convert.ToInt32(Console.ReadLine()),
    zB = Convert.ToInt32(Console.ReadLine());
    dist = Math.Sqrt(Math.Pow(xB-xA, 2)+ Math.Pow(yB-yA, 2)+ Math.Pow(zB-zA, 2));
    dist = Math.Round(dist, 2);
    Console.WriteLine(dist);
}
count++;
}
Zadacha21();
