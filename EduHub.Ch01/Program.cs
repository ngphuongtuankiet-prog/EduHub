using System;
using EduHub.Ch01.Domain;

namespace EduHub.Ch01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            try
            {
                // 1. Tao sinh vien
                Student student = Student.Create(
                    0,
                    "Nguyen Van An",
                    "an@example.com"
                );

                // 2. Tao khoa hoc
                Course course = Course.Create(
                    101,
                    "Lap trinh huong doi tuong"
                );

                // 3. Tao dang ky hoc
                Enrollment enrollment = Enrollment.Create(
                    1001,
                    student,
                    course
                );

                // 4. Tao giang vien
                Instructor instructor = Instructor.Create(
                    1,
                    "Nguyen Thi B"
                );

                // 5. Tao khoa
                Department department = Department.Create(
                    1,
                    "Cong nghe thong tin"
                );

                // 6. In bao cao
                Console.WriteLine("===== EDUHUB CONSOLE DEMO =====");

                Console.WriteLine("\n--- THONG TIN SINH VIEN ---");
                Console.WriteLine($"Ma sinh vien: {student.Id}");
                Console.WriteLine($"Ho ten: {student.FullName}");
                Console.WriteLine($"Email: {student.Email}");

                Console.WriteLine("\n--- THONG TIN KHOA HOC ---");
                Console.WriteLine($"Ma khoa hoc: {course.Id}");
                Console.WriteLine($"Ten khoa hoc: {course.Name}");

                Console.WriteLine("\n--- THONG TIN DANG KY ---");
                Console.WriteLine($"Ma dang ky: {enrollment.Id}");
                Console.WriteLine($"Sinh vien: {enrollment.Student.FullName}");
                Console.WriteLine($"Khoa hoc: {enrollment.Course.Name}");
                Console.WriteLine("Trang thai: Dang ky thanh cong");

                Console.WriteLine("\n--- THONG TIN GIANG VIEN ---");
                Console.WriteLine($"Ma giang vien: {instructor.Id}");
                Console.WriteLine($"Ho ten giang vien: {instructor.FullName}");

                Console.WriteLine("\n--- THONG TIN KHOA ---");
                Console.WriteLine($"Ma khoa: {department.Id}");
                Console.WriteLine($"Ten khoa: {department.Name}");

                Console.WriteLine("\nBao cao duoc tao thanh cong!");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Loi du lieu: {ex.Message}");
            }

            Console.WriteLine("\nNhan phim bat ky de thoat...");
            Console.ReadKey();
        }
    }
}