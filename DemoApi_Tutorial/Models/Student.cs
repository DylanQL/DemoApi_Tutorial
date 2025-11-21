
namespace DemoApi_Tutorial.Models;

public class Student
{   
    public int StudentId { get; set; }
    public string Name { get; set; }
    public int GradeId { get; set; }
    // Navigation Property
    public Grade Grade { get; set; }
}