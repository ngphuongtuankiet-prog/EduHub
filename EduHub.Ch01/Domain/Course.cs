
using System;

namespace EduHub.Ch01.Domain
{
    public class Course
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        private Course()
        {
            Name = string.Empty;
        }

        public static Course Create(int id, string name)
        {
            if (id <= 0)
                throw new ArgumentException("Course ID must be greater than 0.");

            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Course name is required.");

            return new Course
            {
                Id = id,
                Name = name.Trim()
            };
        }
    }
}
