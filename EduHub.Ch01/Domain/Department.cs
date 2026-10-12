
using System;

namespace EduHub.Ch01.Domain
{
    public class Department
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        private Department()
        {
            Name = string.Empty;
        }

        public static Department Create(int id, string name)
        {
            if (id <= 0)
                throw new ArgumentException(
                    "Department ID must be greater than 0.");

            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException(
                    "Department name is required.");

            return new Department
            {
                Id = id,
                Name = name.Trim()
            };
        }
    }
}
