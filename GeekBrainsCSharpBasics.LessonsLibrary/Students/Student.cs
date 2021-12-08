namespace GeekBrainsCSharpBasics.StudentsLibrary
{
    public class Student
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string University { get; set; }

        public string Faculty { get; set; }

        public string Department { get; set; }

        public int Age { get; set; }

        public int Course { get; set; }

        public int Group { get; set; }

        public string City { get; set; }

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

        public Student() { }
    }
}
