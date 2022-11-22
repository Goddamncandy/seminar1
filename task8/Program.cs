Console.WriteLine("Введите число");
int A = Convert.ToInt32(Console.ReadLine());
for (int B = 2; B < A;)
{
    Console.WriteLine(B);
    B = B + 2;
}