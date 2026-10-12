
using System;

namespace EduHub.Ch01.Domain
{
    public class Enrollment
    {
        public int Id { get; private set; }
        public Student Student { get; private set; }
        public Course Course { get; private set; }

        private Enrollment()
        {
            Student = null!;
            Course = null!;
        }

        public static Enrollment Create(
            int id,
            Student student,
            Course course)
        {
            if (id <= 0)
                throw new ArgumentException("Enrollment ID must be greater than 0.");

            if (student == null)
                throw new ArgumentNullException(nameof(student));

            if (course == null)
                throw new ArgumentNullException(nameof(course));

            return new Enrollment
            {
                Id = id,
                Student = student,
                Course = course
            };
        }
    }
}
