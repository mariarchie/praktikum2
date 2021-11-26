//Правила игры:
int leftBound = 1;
int rightBound = 100;
int CountofAttemps = 6;

// Загадываем число в диапазоне
int createNumber(int leftBound, int rightBound)
{
    int SecreteNumber = new Random().Next(leftBound, rightBound);
    return SecreteNumber;
}
int G = createNumber(leftBound, rightBound);
Console.WriteLine(G);

//Игрок вводит число
Console.WriteLine("Введите число: ");
int requestNumber(string N)
{
    int n = Int32.Parse(N);
    return n;
}
int F = requestNumber(Console.ReadLine());

//Тело цикла

bool MaGeMove(int SecreteNumber, int n)
{
    if (F == G)
    {
        Console.WriteLine($"Вы угадали");
        return true;
    }
    else
    {
        if (F < G)
        {
            Console.WriteLine($"загаданное число больше");
            
        }
        if (F > G)
        {
            Console.WriteLine($"загаданное число меньше");
            
        }
    }
    return false;
}


// string MaGeMove(int SecreteNumber, int n, int CountofAttemps)
// {
//     string result = string.Empty;


//     if (F == G)
//     {
//         result = $"Вы угадали";
//         return result;
//     }
//     else

//     {

//         if (F < G)
//         {
//             result = $"загаданное число больше, осталось попыток: {CountofAttemps - 1}";

//         }
//         else
//         {
//             result = $"загаданное число меньше, осталось попыток: {CountofAttemps - 1}";
//         }
//         return result;

//     }
// }
// Console.WriteLine(MaGeMove(F, G, CountofAttemps));




for (int i = 1; i < CountofAttemps; i++)
{
    bool result = MaGeMove(F, G);
    int anotherNumber = requestNumber(Console.ReadLine());
    if (result == true)
    {
        
        Console.WriteLine("Конец");
        break;
    }

}