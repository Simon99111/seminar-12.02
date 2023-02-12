double a = Convert.ToDouble(Console.ReadLine());
double b = Convert.ToDouble(Console.ReadLine());
if (a % b == 0)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
    Console.WriteLine(a % b);
}