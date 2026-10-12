using System;
namespace EduHub.Ch01.Domain
{
    public class Student
    {
        public int Id { get; private set; }
        public string FullName { get; private set; }
        public string Email { get; private set; }

        private Student()
        {
            FullName = string.Empty;
            Email = string.Empty;
        }

        public static Student Create(int id, string fullName, string email)
        {
            if (id <= 0)
                throw new ArgumentException("Id must be greater than 0.");

            if (string.IsNullOrWhiteSpace(fullName))
                throw new ArgumentException("Full name is required.");

            if (string.IsNullOrWhiteSpace(email))
                throw new ArgumentException("Email is required.");

            return new Student
            {
                Id = id,
                FullName = fullName.Trim(),
                Email = email.Trim()
            };
        }
    }
}
