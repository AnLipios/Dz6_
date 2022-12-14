//Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 
//ввёл пользователь.



Console.Write("Введите числа через пробел: ");
int[] numbers = UserArray(Console.ReadLine());
Console.WriteLine($"Количество чисел больше 0: {CountPositive(numbers)}");
Console.WriteLine();


int[] UserArray(string stringArray)
{
    string[] numS = stringArray.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[numS.Length];
    for (int n = 0; n < result.Length; n++)
    {
        result[n] = int.Parse(numS[n]);
    }
    return result;
}

int CountPositive(int[] result)
{

    int count = 0;
    foreach (int s in result)
    {
        if (s>0) 
        {
        count=count +1;
        }
         
    }
   return count;
}