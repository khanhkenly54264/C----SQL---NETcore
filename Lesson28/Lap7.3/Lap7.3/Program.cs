using System;

// Tạo ngoại lệ tùy chỉnh cho điểm không hợp lệ
public class InvalidMarkException : Exception
{
    public InvalidMarkException(string message) : base(message) { }
}

// Lớp Student
public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    private double theoryMark;
    private double labMark;

    // Constructor
    public Student(int id, string name, double theoryMark, double labMark)
    {
        Id = id;
        Name = name;
        TheoryMark = theoryMark;
        LabMark = labMark;
    }

    // Thuộc tính cho điểm lý thuyết
    public double TheoryMark
    {
        get { return theoryMark; }
        set
        {
            if (value < 0 || value > 10)
            {
                throw new InvalidMarkException("Điểm lý thuyết phải nằm trong khoảng 0 đến 10.");
            }
            theoryMark = value;
        }
    }

    // Thuộc tính cho điểm thực hành
    public double LabMark
    {
        get { return labMark; }
        set
        {
            if (value < 0 || value > 10)
            {
                throw new InvalidMarkException("Điểm thực hành phải nằm trong khoảng 0 đến 10.");
            }
            labMark = value;
        }
    }

    // Phương thức hiển thị thông tin sinh viên
    public void DisplayStudentInfo()
    {
        Console.WriteLine($"ID: {Id}, Tên: {Name}, Điểm lý thuyết: {TheoryMark}, Điểm thực hành: {LabMark}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Default;
        try
        {
            // Tạo đối tượng sinh viên với điểm hợp lệ
            Student student1 = new Student(1, "Nguyen Van A", 8.5, 9);
            student1.DisplayStudentInfo();

            // Tạo đối tượng sinh viên với điểm không hợp lệ (ném ngoại lệ)
            Student student2 = new Student(2, "Tran Thi B", 12, 8); // Điểm lý thuyết > 10
        }
        catch (InvalidMarkException ex)
        {
            Console.WriteLine($"Lỗi: {ex.Message}");
        }
    }
}
