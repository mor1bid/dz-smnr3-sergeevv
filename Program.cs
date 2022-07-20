// static void Zadacha19(string[] args)
//         {
//         int reverse=0;
//         int number = 12823;

//         while (number > 0)
//         {
//             reverse = number % 10;
//             Console.Write(reverse);
//             number = number / 10;  
//         }
//         }
// Zadacha19(args);
// // if (num >= 10000 && num < 100000)
// // {
// //     while (countnum<5) 
// //     {
        
// //     }
// // } else 
// // {
// //     Console.WriteLine ("Задано не пятизначное число.");
// // }
// // }
// Zadacha19();

 void Zadacha21 () 
 {
     double dist;
     Console.WriteLine("Введите координаты x, y, z точки A: ");
     double xA = double.PositiveInfinity,
     yA = double.PositiveInfinity,
     zA = double.PositiveInfinity;
     Console.WriteLine("Введите координаты x, y, z точки B: ");
     double xB = double.PositiveInfinity,
     yB = double.PositiveInfinity,
     zB = double.PositiveInfinity;
     dist = Math.Sqrt(Math.Pow(xB-xA, 2)+ Math.Pow(yB-yA, 2)+ Math.Pow(zB-zA, 2));
     dist = Math.Round(dist, 2); //округление, где число после запятой - колво значений
     Console.WriteLine(dist);
 }
 Console.WriteLine("");
 Zadacha21();

void Zadacha23()
{
     double num = double.PositiveInfinity+1;
     int countnum = 0;
     while (countnum < num) 
         {
             countnum += 1;
             string numc = ($"{countnum*countnum*countnum}");
             Console.WriteLine(countnum + "^3 = " + numc);
         }
}
Zadacha23();