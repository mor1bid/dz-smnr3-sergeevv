﻿ static void Zadacha19(string[] args)
         {
         int reverse1=0, reverse2=0;
         //int number = new Random().Next(10000, 99999);
         int num = 12831;
         Console.WriteLine(num);
         int amun = num;
         while (amun > 0)
         {
             reverse1 = amun % 10;
             Console.Write(reverse1);
             amun = amun / 10;
         }
         int bmun = reverse2;
         while (bmun > 0)
         {
             reverse2 = bmun % 100;
             //Console.Write(reverse2);
             bmun = bmun / 100;
         }

         Console.WriteLine("");
         if (reverse1 == num % 10 && reverse2 == (num % 100)/100) 
         {
            Console.WriteLine("Число " + num + " - палиндром");
         } 
         else 
         {
            Console.WriteLine("Число " + num + " - не палиндром");
         }
         Console.WriteLine("");
         }
Console.WriteLine("");
Zadacha19(args);

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
    Console.WriteLine("Zadacha21");
     double dist;
     //Console.WriteLine("Введите координаты x, y, z точки A: ");
     int xA = new Random().Next(1, 10),
     yA = new Random().Next(1, 10),
     zA = new Random().Next(1, 10);
     //Console.WriteLine("Введите координаты x, y, z точки B: ");
     int xB = new Random().Next(1, 10),
     yB = new Random().Next(1, 10),
     zB = new Random().Next(1, 10);
     dist = Math.Sqrt(Math.Pow(xB-xA, 2)+ Math.Pow(yB-yA, 2)+ Math.Pow(zB-zA, 2));
     dist = Math.Round(dist, 2); //округление, где число после запятой - колво значений
     Console.WriteLine("Расстояние между точкой A " + "(" + xA + " , " + yA + " , " + zA + ")" + " и точкой B " + "(" + xB + " , " + yB + " , " + zB + ")" + " = " + dist);
     Console.WriteLine("");
 }
 Zadacha21();

void Zadacha23()
{
    Console.WriteLine("Zadacha23");
     double num = new Random().Next(1, 10);
     int countnum = 0;
     while (countnum < num) 
         {
             countnum += 1;
             string numc = ($"{countnum*countnum*countnum}");
             Console.WriteLine(countnum + "^3 = " + numc);
         }
}
Zadacha23();