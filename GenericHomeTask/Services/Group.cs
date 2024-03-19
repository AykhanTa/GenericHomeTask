namespace GenericHomeTask.Services
{
    internal class Group
    {
        static string no = "AP101";
        public string No { get; }
        List<Student> Students;
        public Group()
        {
            Students = new List<Student>();
            no = IncreaseGroupNo();
            No = no;
        }
        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        public void GetAllStudents()
        {
            foreach (var student in Students)
            {
                Console.WriteLine($"{student.Id}. Group:{No} Name:{student.Name}, Surname:{student.Surname}, Point:{student.Point}");
            }
        }
        public void Sort()
        {
            List<Student> stuSorted = new List<Student>();
            stuSorted = Students;
            stuSorted.Sort((x, y) => x.Point.CompareTo(y.Point));

            foreach (var item in stuSorted)
            {
                Console.WriteLine($"{item.Id}. Group:{No} Name:{item.Name}, Surname:{item.Surname}, Point:{item.Point}");
            }

        }

        public static string IncreaseGroupNo()
        {          
            int index = 0;
            for (int i = 0; i < no.Length; i++)
            {
                if (char.IsDigit(no[i]))
                {
                    index = i;
                    break;
                }
            }
            string subStr = no.Substring(index, 3);
            int num = int.Parse(subStr);
            num++;
            var result = $"AP{num}";
            return result;

        }

    }
}
