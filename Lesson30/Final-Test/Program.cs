// Bài 1: Tạo interface IStudent với các thuộc tính và phương thức yêu cầu.
// Bài 2: Tạo class Student với các thuộc tính, phương thức và tính năng tính trung bình điểm.
// Bài 3: Tạo menu điều khiển chính.
//  4: Xử lý khi người dùng chọn thêm sinh viên mới và lưu vào Hashtable.
//  5: Xử lý khi người dùng chọn hiển thị danh sách sinh viên.
//  6: Xử lý khi người dùng chọn tính và hiển thị điểm trung bình.
//  7: Quay lại menu cho đến khi người dùng chọn Thoát.

using System;
using System.Collections;
using System.Collections.Generic;

public interface IStudent
{
    int StudID { get; set; }
    string StudName { get; set; }
    string StudGender { get; set; }
    int StudAge { get; set; }
    string StudClass { get; set; }
    float StudAvgMark { get; } // Thuộc tính chỉ đọc

    void Print();
}

public class Student : IStudent
{
    public int StudID { get; set; }
    public string StudName { get; set; }
    public string StudGender { get; set; }
    public int StudAge { get; set; }
    public string StudClass { get; set; }
    private float studAvgMark;
    public float StudAvgMark => studAvgMark;

    private int[] MarkList = new int[3]; // Mảng 3 phần tử cho điểm số

    public void Print()
    {
        Console.WriteLine($"Mã sinh viên: {StudID}");
        Console.WriteLine($"Tên sinh viên: {StudName}");
        Console.WriteLine($"Giới tính: {StudGender}");
        Console.WriteLine($"Tuổi: {StudAge}");
        Console.WriteLine($"Lớp: {StudClass}");
        Console.WriteLine($"Điểm trung bình: {StudAvgMark}");
    }

    public int this[int index]
    {
        get { return MarkList[index]; }
        set { MarkList[index] = value; }
    }

    public void CalAvg()
    {
        studAvgMark = (float)(MarkList[0] + MarkList[1] + MarkList[2]) / 3;
    }
}

public class Program
{
    static Hashtable studentTable = new Hashtable(); // Hashtable lưu trữ sinh viên với khóa là StudID

    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Default;
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Vui lòng chọn một tùy chọn:");
            Console.WriteLine("1. Thêm sinh viên mới");
            Console.WriteLine("2. Hiển thị danh sách sinh viên");
            Console.WriteLine("3. Tính điểm trung bình");
            Console.WriteLine("4. Thoát");
            Console.Write("Nhập lựa chọn của bạn: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("» » » » » » » » » » » » » » »");
                    InsertStudent();
                    break;
                case "2":
                    Console.WriteLine("» » » » » » » » » » » » » » »");
                    DisplayStudents();
                    break;
                case "3":
                    Console.WriteLine("» » » » » » » » » » » » » » »");
                    CalculateAverage();
                    break;
                case "4":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Tùy chọn không hợp lệ. Vui lòng thử lại.");
                    break;
            }
        }
    }

    static void InsertStudent()
    {
        var student = new Student();

        Console.Write("Nhập mã sinh viên: ");
        student.StudID = int.Parse(Console.ReadLine());

        Console.Write("Nhập tên sinh viên: ");
        student.StudName = Console.ReadLine();

        Console.Write("Nhập giới tính: ");
        student.StudGender = Console.ReadLine();

        Console.Write("Nhập tuổi: ");
        student.StudAge = int.Parse(Console.ReadLine());

        Console.Write("Nhập lớp: ");
        student.StudClass = Console.ReadLine();

        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Nhập điểm {i + 1}: ");
            student[i] = int.Parse(Console.ReadLine());
        }

        student.CalAvg();
        studentTable[student.StudID] = student; // Thêm sinh viên vào Hashtable
    }

    static void DisplayStudents()
    {
        foreach (Student student in studentTable.Values)
        {
            student.Print();
            Console.WriteLine();
        }
    }

    static void CalculateAverage()
    {
        foreach (Student student in studentTable.Values)
        {
            student.CalAvg();
            student.Print();
        }
    }
}

