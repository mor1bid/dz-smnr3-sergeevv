void Zadacha19 () {
Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine()), countnum = 0, cut = 10;
if (num >= 10000 && num < 100000) 
{
    while (countnum<5) 
    {
        int res = num % cut;
        res = num / cut;
        res = num % cut;
        Console.WriteLine(res);
        cut *= 10;
        countnum += 1;
    }
} else 
{
    Console.WriteLine ("Задано не пятизначное число.");
}
}
Zadacha19();

// void Zadacha21 () {
// int ind = 999, count = 0;
// while(ind > count) 
// {
//     double dist;
//     Console.WriteLine("Введите координаты x, y, z точки A: ");
//     int xA = Convert.ToInt32(Console.ReadLine()),
//     yA = Convert.ToInt32(Console.ReadLine()),
//     zA = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите координаты x, y, z точки B: ");
//     int xB = Convert.ToInt32(Console.ReadLine()),
//     yB = Convert.ToInt32(Console.ReadLine()),
//     zB = Convert.ToInt32(Console.ReadLine());
//     dist = Math.Sqrt(Math.Pow(xB-xA, 2)+ Math.Pow(yB-yA, 2)+ Math.Pow(zB-zA, 2));
//     dist = Math.Round(dist, 2); //округление, где число после запятой - колво значений
//     Console.WriteLine(dist);
// }
// count++;
// }
// Zadacha21();

// void Zadacha23()
// {
// int ind = 999, count = 0;
// while (count < ind) 
// {
//     Console.WriteLine("Введите число: ");
//     int num = Convert.ToInt32(Console.ReadLine());
//     int countnum = 0;
//     while (countnum < num) 
//         {
//             countnum += 1;
//             string numc = ($"{countnum*countnum*countnum}");
//             Console.WriteLine(countnum + "^3 = " + numc);
//         }
// count++;
// }
// }
// Zadacha23();