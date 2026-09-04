using System;
using System.Collections.Generic;
using System.Linq;
using prj1.Model; 

namespace prj1.Services
{
    public class StudentManager
    {
        // Sử dụng danh sách readonly để bảo vệ tham chiếu nội bộ
        private readonly List<Student> _students;

        public StudentManager()
        {
            _students = new List<Student>();
        }

        // 1. Thêm sinh viên mới (Có kiểm tra trùng ID và dữ liệu null)
        public void AddStudent(Student student)
        {
            if (student == null)
            {
                Console.WriteLine("[Hệ thống] Dữ liệu sinh viên không hợp lệ.");
                return;
            }

            if (_students.Any(s => s.Id == student.Id))
            {
                Console.WriteLine($"[Hệ thống] ID {student.Id} đã tồn tại trong hệ thống.");
                return;
            }

            _students.Add(student);
            Console.WriteLine($"[Hệ thống] Đã thêm thành công sinh viên: {student.Name}");
        }

        // 2. Lấy danh sách tất cả sinh viên
        public List<Student> GetAllStudents()
        {
            return _students;
        }

        // 3. Hiển thị thông tin tất cả sinh viên ra màn hình
        public void DisplayAllStudents()
        {
            if (!_students.Any())
            {
                Console.WriteLine("[Hệ thống] Danh sách sinh viên trống.");
                return;
            }

            foreach (var student in _students)
            {
                // Gọi phương thức hiển thị từ lớp Student (nếu có)
                student.DisplayStudentInfo(); 
            }
        }

        // 4. Tìm kiếm sinh viên theo Mã số (Id)
        public Student? GetStudentById(int id)
        {
            return _students.FirstOrDefault(s => s.Id == id);
        }

        // 5. Xóa sinh viên theo Mã số (Id)
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