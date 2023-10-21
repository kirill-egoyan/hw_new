System.Console.Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
int B = 1;
int result = 0;
int ost = 0;
while(A > B)
{
    ost = A % 10;
    A = A / 10;
    result = result + ost;
}
System.Console.WriteLine(result);