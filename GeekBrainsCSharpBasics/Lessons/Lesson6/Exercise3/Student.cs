namespace GeekBrainsCSharpBasics.Lesson6
{
    public class Student
    {
        public string Name { get; }

        public string Surname { get; }

        public string University { get; }

        public string Faculty { get; }

        public string Department { get; }

        public int Age { get; }

        public int Course { get; }

        public int Group { get; }

        public string City { get; }

        public Student(string name, string surname, string university, string faculty, string department, int age, int course, int group, string city)
        {
            Name = name;
            Surname = surname;
            University = university;
            Faculty = faculty;
            Department = department;
            Age = age;
            Course = course;
            Group = group;
            City = city;
        }
    }
}
