Console.WriteLine("Введите число");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int C = Convert.ToInt32(Console.ReadLine());
if (A > B && A > C)
{
    Console.WriteLine(A);
}
else if (B > C)
{
    Console.WriteLine(B);
}
else
{
    Console.WriteLine(C);
}