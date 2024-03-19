namespace GenericHomeTask.Services
{
    internal class Student
    {
        static int id = 0;
        public int Id { get; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int Point { get; set; }
        public Student(string name, string surname, int point)
        {
            Name = name;
            Surname = surname;
            Point = point;
            id++;
            Id = id;
        }

        public static bool operator >(Student a, Student b)
        {
            return a.Point > b.Point;
        }
        public static bool operator <(Student a, Student b)
        {
            return a.Point < b.Point;
        }

    }
}
