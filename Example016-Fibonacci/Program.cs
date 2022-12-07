int fibonacci(int N)
{
  if (N == 1 || N ==  2) return 1; 
  else return fibonacci(N - 1) + fibonacci(N - 2);
}

//Console.Write("Введите n: ");
//int n = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine($"f({n}) = {fibonacci(n)}");

for (int n = 1; n <= 40; n++)
{
  Console.WriteLine($"f({n}) = {fibonacci(n)}");
}
