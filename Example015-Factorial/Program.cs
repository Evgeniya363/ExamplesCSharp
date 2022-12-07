// int factorial(int N)
// {
//   if (N == 1) return 1;
//   else return N * factorial(N - 1);
// }

// Console.Write("Введите n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"{n}! = {factorial(n)}");


double factorial(double N)
{
    if (N==1) return 1;
    else return N * factorial(N-1);
}

for (double i=1; i<=40; i++)
{
    Console.WriteLine($"{i}! = {factorial(i)}");
}

