
int GetNumber(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int number = Convert.ToInt32(value);
    return number;
}

void GetResult(int b1, int b2, int k1, int k2)
{
   int x = (b2 - b1)/(k1 - k2);
   int y = k1 * x + b1;
   Console.WriteLine($"Координаты точки пересечения x = {x}  y = {y}");
}

int b1 = GetNumber("Введите b1 ");
int b2 = GetNumber("Введите b2 ");
int k1 = GetNumber("Введите k1 ");
int k2 = GetNumber("Введите k2 ");
GetResult(b1, b2, k1, k2);
