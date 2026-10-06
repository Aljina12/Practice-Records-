Student student = new Student();

student.Name = "Aljina";
student.Course = "Computing";

student.DisplayDetails();

class Student
{
    public string Name { get; set; } = "";
    public string Course { get; set; } = "";

    public void DisplayDetails()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Course: {Course}");
    }
}