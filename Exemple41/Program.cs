
int GetNumber(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int number = Convert.ToInt32(value);
    return number;
}

void GetIndex(int number, int[] array)
{
    for(int i = 0; i < number; i++)
    {
    Console.Write($"Введите {i} число ");
    string value = Console.ReadLine();
    array[i] = Convert.ToInt32(value);
    }
}

void GetResult(int number, int[] array)
{
    int count = 1;
    for(int i = 0; i < number; i++)
    {
        if(array[i] > 0) count += 1;
    }
    Console.WriteLine(count);
}


int number = GetNumber("Введите необходимое количество цифр для ввода  ");
int[] array = new int[number]; 
GetIndex(number, array);
GetResult(number, array);

