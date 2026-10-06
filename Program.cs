Console.Write("Enter first number: ");
int first = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter second number: ");
int second = Convert.ToInt32(Console.ReadLine());

int result = AddNumbers(first, second);

Console.WriteLine($"Result: {result}");

static int AddNumbers(int a, int b)
{
    return a + b;
}