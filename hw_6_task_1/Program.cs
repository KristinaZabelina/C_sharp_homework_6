int getUserData (string message)
{
    Console.WriteLine(message);
    int UserData = int.Parse(Console.ReadLine()!);
    return UserData;
}

int lenght = getUserData("Введите количество чисел, которое хотите ввести: ");
int [] numbers = new int [lenght];

for (int i = 0; i < lenght; i++)
{
    Console.WriteLine("Введите число: ");
    numbers [i] = int.Parse(Console.ReadLine()!);
}

int PositiveNumbers(int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] > 0)
        {
            count++;
        }
    }
    return count;
}

int positiveNumbersCount = PositiveNumbers(numbers);
Console.WriteLine($"Количество чисел больше 0 равно {positiveNumbersCount}");
