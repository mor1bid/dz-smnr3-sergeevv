﻿// void Zadacha19 () {
// Console.WriteLine("Введите число:");
// int num = Convert.ToInt32(Console.ReadLine.Next());
// if (num >= 10000 && num <= 9999) 
// num %= 10;

// }
// Zadacha19();

void Zadacha21 () {
int dist;
Console.WriteLine("Введите координаты x, y, z точки A: ");
int xA = Convert.ToInt32(Console.ReadLine()),
yA = Convert.ToInt32(Console.ReadLine()),
zA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты x, y, z точки B: ");
int xB = Convert.ToInt32(Console.ReadLine()),
yB = Convert.ToInt32(Console.ReadLine()),
zB = Convert.ToInt32(Console.ReadLine());

dist = (xA-xB)^2+(yA-yB)^2+(zA-zB)^2;
Console.WriteLine(dist);
}
Zadacha21();
