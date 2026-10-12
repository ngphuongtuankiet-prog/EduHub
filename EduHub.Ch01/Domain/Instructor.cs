
using System;

namespace EduHub.Ch01.Domain
{
    public class Instructor
    {
        public int Id { get; private set; }
        public string FullName { get; private set; }

        private Instructor()
        {
            FullName = string.Empty;
        }

        public static Instructor Create(int id, string fullName)
        {
            if (id <= 0)
                throw new ArgumentException("Instructor ID must be greater than 0.");

            if (string.IsNullOrWhiteSpace(fullName))
                throw new ArgumentException("Instructor name is required.");

            return new Instructor
            {
                Id = id,
                FullName = fullName.Trim()
            };
        }
    }
}
