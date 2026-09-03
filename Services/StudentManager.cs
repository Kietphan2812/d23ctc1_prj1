using System;
using System.Collections.Generic;
using System.Linq;
// Khớp với namespace chứa lớp Student của bạn
using prj1.Model; 

namespace prj1.Services
{
    public class StudentManager
    {
        // Khởi tạo danh sách quản lý sinh viên nội bộ
        private List<Student> _students = new List<Student>();

        // 1. Thêm sinh viên mới
        public void AddStudent(Student student)
        {
            if (student == null) return;
            _students.Add(student);
            Console.WriteLine($"[Hệ thống] Đã thêm thành công sinh viên: {student.Name}");
        }

        // 2. Lấy danh sách tất cả sinh viên
        public List<Student> GetAllStudents()
        {
            return _students;
        }

        // 3. Tìm kiếm sinh viên theo Mã số (Id kiểu int)
        public Student? GetStudentById(int id)
        {
            return _students.FirstOrDefault(s => s.Id == id);
        }

        // 4. Xóa sinh viên theo Mã số (Id kiểu int)
        public bool DeleteStudent(int id)
        {
            var student = GetStudentById(id);
            if (student != null)
            {
                _students.Remove(student);
                Console.WriteLine($"[Hệ thống] Đã xóa sinh viên có ID: {id}");
                return true;
            }
            Console.WriteLine($"[Hệ thống] Không tìm thấy sinh viên có ID: {id} để xóa.");
            return false;
        }
    }
}