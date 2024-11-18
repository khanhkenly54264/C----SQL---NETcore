namespace Lab6._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student{Id="S10",FirstName="Nguyen Thu",LastName= "Phuong",Avg=9.5},
                new Student{Id="S12",FirstName="Tran Thi",LastName= "Thuy",Avg=9.0},
                new Student{Id="S13",FirstName="Le Hoang",LastName= "Nhat",Avg=8.0},
                new Student{Id="S14",FirstName="Nguyen Van",LastName= "Phong",Avg=6.5},
                new Student{Id="S15",FirstName="Hoang Thi",LastName= "Hue",Avg=9.7},
                new Student{Id="S16",FirstName="Nguyen Tien",LastName= "Tung",Avg=5.0},
                new Student{Id="S17",FirstName="Nguyen Thien",LastName= "Nhan",Avg=4.8},
            };
            Console.WriteLine("Danh sach nhan vien:");
            foreach (var student in students) 
            {
                Console.WriteLine(student);
            }
            double max = students[0].Avg;
            Student stdMax = students[0];
            foreach (var student in students)
            {
                if(student.Avg > max)
                {
                    max = student.Avg;
                    stdMax = student;
                }
            }
            Console.WriteLine("Sinh vien co diem cao nhat la:");
            Console.WriteLine(stdMax);
        }
    }
}
