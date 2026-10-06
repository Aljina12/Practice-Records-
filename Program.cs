Console.Write("Enter your marks: ");
int marks = Convert.ToInt32(Console.ReadLine());

if (marks >= 80)
{
    Console.WriteLine("Grade A");
}
else if (marks >= 60)
{
    Console.WriteLine("Grade B");
}
else if (marks >= 40)
{
    Console.WriteLine("Grade C");
}
else
{
    Console.WriteLine("Fail");
}