Console.WriteLine("Введите число:");
int num = Convert.ToInt32(1000-9999);
if (num % 2 == 0) {
    num %= 10;
    Console.WriteLine("Число чётное. Остаток: " + num); }
    else 
    {
    num %= 10;
    Console.WriteLine("Число нечётное Остаток: " + num);
    }