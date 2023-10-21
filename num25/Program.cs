System.Console.Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите степень: ");
int B = Convert.ToInt32(Console.ReadLine());
int count = 0;
int result = 1;
while(count < B)
{
    result = result * A;
    count++;
}
System.Console.WriteLine(result);