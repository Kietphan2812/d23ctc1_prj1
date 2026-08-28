using prj1.Model;
using prj1.Service;
public class Program
{
    public static void Main(string[] args)
    {
        StudentManager studentManager = new StudentManager();
        Student student1 = new Student(1, "Alice", 20);
        Student student2 = new Student(2, "Bob", 22);

        studentManager.AddStudent(student1);
        studentManager.AddStudent(student2);
        studentManager.DisplayAllStudents();

    }
}   
