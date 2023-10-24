int[] ArrayGen(int min, int max)
{
    int[] array = new int[8];
   
    Random random = new Random();
    for (int i = 0; i < 8; i++)
    {
        array[i] = random.Next(min,max + 1);
    }
    return array;
}
void DisplayArray(int[] array)
{
    System.Console.Write("[ ");
    for(int i = 0;i < 8; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine("]");
}

System.Console.Write("Введите минимальное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите максимальное значение: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] array = ArrayGen(min, max);
DisplayArray(array);