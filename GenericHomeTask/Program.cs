using GenericHomeTask.Services;

namespace GenericHomeTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student stu1 = new("Abulfaz","Aliyev",100);
            //Student stu2 = new("Emin","Aliyev",150);
            //Console.WriteLine(stu1>stu2);
            //Console.WriteLine(stu1<stu2);

            Student stu1 = new("Abulfaz", "Aliyev", 100);
            Student stu2 = new("Emin", "Aliyev", 150);
            Student stu3 = new("Kamran", "Bakshaliyev", 70);
            Student stu4 = new("Ayxan", "Taghizada", 50);

            Group group1 = new();
            group1.AddStudent(stu1);
            group1.AddStudent(stu2);
            group1.AddStudent(stu3);
            group1.AddStudent(stu4);
            group1.GetAllStudents();
            Console.WriteLine();
            //group1.Sort();

            Group group2=new();
            group2.AddStudent(stu1);
            group2.AddStudent(stu2);
            group2.AddStudent(stu3);
            group2.AddStudent(stu4);
            group2.Sort();     
            Console.WriteLine();


        }
    }
}
