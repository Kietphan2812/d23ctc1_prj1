using System;
using prj1.Model;
using prj1.Services;
namespace prj1.Services
{
class Program
{
    static void Main(string[] args)
    {
        // --- PHẦN 1: KHỞI TẠO ĐỐI TƯỢNG ĐỘC LẬP (Code cũ của bạn) ---
        Console.WriteLine("--- Khởi tạo và hiển thị sinh viên độc lập ---");
        Student student1 = new Student(1, "Alice", 20);
        Student student2 = new Student(2, "Bob", 22);

        student1.DisplayStudentInfo();
        student2.DisplayStudentInfo();


        // --- PHẦN 2: SỬ DỤNG STUDENTMANAGER ĐỂ QUẢN LÝ (Code nâng cao) ---
        Console.WriteLine("\n--- Thử nghiệm hệ thống StudentManager ---");
        
        // 1. Khởi tạo đối tượng quản lý
        StudentManager manager = new StudentManager();

        // 2. Thêm dữ liệu (Đưa luôn Alice và Bob vào danh sách quản lý)
        manager.AddStudent(student1);
        manager.AddStudent(student2);
        // Thêm sinh viên mới nếu muốn
        manager.AddStudent(new Student(3, "Nguyen Van A", 20));

        // 3. Hiển thị toàn bộ danh sách sinh viên đang quản lý
        Console.WriteLine("\n--- Danh sách sinh viên hiện tại trong Manager ---");
        foreach (var student in manager.GetAllStudents())
        {
            student.DisplayStudentInfo();
        }

        // 4. Tìm kiếm thử nghiệm sinh viên theo ID
        Console.WriteLine("\n--- Tìm kiếm sinh viên ID = 1 ---");
        var foundStudent = manager.GetStudentById(1);
        if (foundStudent != null) 
        {
            foundStudent.DisplayStudentInfo();
        }

        // 5. Xóa thử nghiệm sinh viên ra khỏi danh sách theo ID
        Console.WriteLine("\n--- Xóa sinh viên ID = 2 (Bob) ---");
        manager.DeleteStudent(2);

        // 6. Kiểm tra lại danh sách sau khi xóa để xác nhận
        Console.WriteLine("\n--- Danh sách sinh viên sau khi xóa ID 2 ---");
        foreach (var student in manager.GetAllStudents())
        {
            student.DisplayStudentInfo();
        }
    }
}
}