using System;
using prj1.Model;
using prj1.Service;

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
        manager.AddStudent(new Student(3, "Nguyen Van A", 20));

        // 3. Hiển thị toàn bộ danh sách sinh viên đang quản lý
        Console.WriteLine("\n--- Danh sách sinh viên hiện tại trong Manager ---");
        // ĐÃ SỬA: Gọi thẳng hàm tự in danh sách của bạn, không dùng vòng lặp foreach ở đây nữa
        manager.DisplayAllStudents(); 


        // 4. Tìm kiếm thử nghiệm sinh viên theo ID
        Console.WriteLine("\n--- Tìm kiếm sinh viên ID = 1 ---");
        var foundStudent = manager.GetStudentById(1);
        if (foundStudent != null) 
        {
            foundStudent.DisplayStudentInfo();
        }
        else
        {
            Console.WriteLine("[Hệ thống] Không tìm thấy sinh viên có ID = 1.");
        }

        // Lưu ý: Lớp StudentManager của bạn hiện tại CHƯA định nghĩa hàm DeleteStudent (Xóa).
        // Nếu bạn muốn chạy tính năng xóa ở mục 5 và mục 6, bạn cần bổ sung hàm DeleteStudent vào file StudentManager.cs nhé!
    }
}