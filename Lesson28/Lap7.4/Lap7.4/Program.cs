
// Tạo lớp Exception tùy chỉnh cho các lỗi về lương và thưởng
public class AmountException : Exception
{
    public AmountException(string message) : base(message)
    {
    }
}

// Tạo lớp Lecture
public class Lecture
{
    // Các thuộc tính
    public string Name { get; set; }
    public double Salary { get; set; }
    public double Bonus { get; set; }

    // Hàm khởi tạo
    public Lecture(string name, double salary, double bonus)
    {
        Name = name;
        Salary = salary;
        Bonus = bonus;

        // Kiểm tra điều kiện ngoại lệ
        if (Salary < 60000)
        {
            throw new AmountException("Lương thấp hơn 60,000$.");
        }

        if (Bonus > 10000)
        {
            throw new AmountException("Thưởng cao hơn 10,000$.");
        }
    }

    // Phương thức hiển thị thông tin
    public void DisplayInfo()
    {
        Console.WriteLine($"Tên: {Name}, Lương: {Salary}$, Thưởng: {Bonus}$");
    }
}

// Chương trình chính để kiểm thử
class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Default;
        try
        {
            // Tạo đối tượng Lecture với thông tin hợp lệ
            Lecture lecture1 = new Lecture("Nguyen Van A", 65000, 8000);
            lecture1.DisplayInfo();

            // Tạo đối tượng Lecture với lương thấp để kiểm tra ngoại lệ
            Lecture lecture2 = new Lecture("Tran Van B", 50000, 9000);
            lecture2.DisplayInfo();
        }
        catch (AmountException ex)
        {
            Console.WriteLine($"Lỗi: {ex.Message}");
        }
    }
}
