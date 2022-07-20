 static void Zadacha19(string[] args)
    {
        Console.WriteLine("Zadacha19");
         int reverse1=0, reverse2=0;
         //int number = new Random().Next(10000, 99999);
         Console.WriteLine("Введите число: ");
         int num = Convert.ToInt32(Console.ReadLine());
         //Console.WriteLine(num);
         int amun = num;
         if (num >= 10000 && num < 100000) 
         {
         while (amun > 0)
            {
                reverse1 = amun % 10;
                Console.Write(reverse1);
                amun = amun / 10;
            }
            int bmun = reverse2;
            reverse2 = bmun % 10000;
            bmun = bmun / 1000;
         
            Console.WriteLine("");
            if (reverse1 == num % 10 && bmun == (num % 100)/10) 
            {
                Console.WriteLine("Число " + num + " - палиндром");
            } 
            else 
            {
                Console.WriteLine("Число " + num + " - не палиндром");
            }
            Console.WriteLine("");
        }
        else 
        {
        Console.WriteLine ("Задано не пятизначное число."); 
        }
        Console.WriteLine("");
    }
Console.WriteLine("");
Zadacha19(args);

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