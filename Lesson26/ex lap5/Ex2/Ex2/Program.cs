using System;
using System.Linq;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public Student(int id, string name, int age)
    {
        Id = id;
        Name = name;
        Age = age;
    }

    public override string ToString()
    {
        return $"ID: {Id}, Name: {Name}, Age: {Age}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Default;
        // Khởi tạo mảng gồm 10 sinh viên
        Student[] students = new Student[10]
        {
            new Student(1, "Student A", 20),
            new Student(2, "Student B", 18),
            new Student(3, "Student C", 22),
            new Student(4, "Student D", 19),
            new Student(5, "Student E", 21),
            new Student(6, "Student F", 23),
            new Student(7, "Student G", 18),
            new Student(8, "Student H", 20),
            new Student(9, "Student I", 17),
            new Student(10, "Student J", 22)
        };


        int chon = 0;
        do
        {
            menu();
            Console.WriteLine("Mời bạn chọn");
            chon = int.Parse(Console.ReadLine());
            switch (chon)
            {
                case 1:
                    Console.WriteLine(" phần tử student có tuổi nhỏ nhất của mảng là: ");
                    MinAgeStudent(students);
                    break;
                case 2:
                    Console.WriteLine("2.Sắp xếp mảng tăng dần theo tuổi sinh viên: ");
                    AgeHihger(students);
                    break;
                case 3:
                    Console.WriteLine("3.sinh viên có tuổi lớn nhất là: ");
                    MaxAgeStydent(students);
                    break;
                case 4:
                    Console.WriteLine("4.Exit");
                    break;
                default:
                    Console.WriteLine("Bạn chọn sai chức năng !");
                    break;
            }
        } while (chon != 4);
    }
    static void menu()
    {
        Console.WriteLine("================= MENU ================");
        Console.WriteLine("1.Tìm phần tử student có tuổi nhỏ nhất của mảng.");
        Console.WriteLine("2.Sắp xếp mảng tăng dần theo tuổi sinh viên (student).");
        Console.WriteLine("3.Tìm sinh viên có tuổi lớn nhất.");
        Console.WriteLine("4.Exit");
    }

    static void MinAgeStudent(Student[] Student)
    {
        Student youngest = Student.OrderBy(s => s.Age).First();
        Console.WriteLine("Sinh viên có tuổi nhỏ nhất: " + youngest);
    }

    static void AgeHihger(Student[] Student)
    {
        var sortedStudents = Student.OrderBy(s => s.Age).ToArray();
        Console.WriteLine("Danh sách sinh viên sắp xếp theo tuổi tăng dần:");
        foreach (var student in sortedStudents)
        {
            Console.WriteLine(student);
        }
    }

    static void MaxAgeStydent(Student[] Student)
    {
        Student oldest = Student.OrderByDescending(s => s.Age).First();
        Console.WriteLine("Sinh viên có tuổi lớn nhất: " + oldest);
    }

}

