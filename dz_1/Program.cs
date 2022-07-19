// пользователь вводит N чисел, сколько чисел больше 0

Console.Write(" Введите число,кол-во которых будем проверять -> ");
int amount = Convert.ToInt32(Console.ReadLine());

int [] FillArray ( int number)
{
    int [] addArray = new int [number];

    for (int i = 0; i < number; i++)
    {
        Console.Write($"Веедите {i+1}-е число : ");
        addArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return addArray;
}
int numberPositive ( int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) count++;
    }
    return count;
}
Console.WriteLine($"Количество чисел больше нуля {numberPositive (FillArray(amount))}");
