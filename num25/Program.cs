int Exponential(int A, int B)
{
int count = 0;
int result = 1;
while(count < B)
{
    result = result * A;
    count++;
}
return result;
}
System.Console.Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите степень: ");
int B = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Exponential(A, B));