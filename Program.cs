using prj1.Model;
public class Program
{
    public static void Main(string[] args)
    {
        Student student1 = new Student(1, "Alice", 20);
        Student student2 = new Student(2, "Bob", 22);

        student1.DisplayStudentInfo();
        student2.DisplayStudentInfo();
    }
}   
