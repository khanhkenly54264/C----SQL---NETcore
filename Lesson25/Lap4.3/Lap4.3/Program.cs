using System;
using System.IO;
using System.Text;

interface IStorage
{
    string Data { get; set; }
    void Read(string filename);
    void Write(string filename);
}

interface IEncryptable
{
    void Encrypt();
    void Decrypt();
}

class Document : IStorage, IEncryptable
{
    public string content { get; set; }

    public string Data
    {
        get { return content; }
        set { content = value; }
    }

    // Đọc nội dung từ tệp
    public void Read(string filename)
    {
        if (File.Exists(filename))
        {
            content = File.ReadAllText(filename);
            Console.WriteLine($"Đã đọc nội dung từ {filename}");
        }
        else
        {
            Console.WriteLine("Tệp không tồn tại.");
        }
    }

    // Ghi nội dung vào tệp
    public void Write(string filename)
    {
        File.WriteAllText(filename, content);
        Console.WriteLine($"Đã ghi nội dung vào {filename}");
    }

    // Mã hóa nội dung (chỉ là ví dụ đơn giản, đổi sang chuỗi base64)
    public void Encrypt()
    {
        byte[] bytes = Encoding.UTF8.GetBytes(content);
        content = Convert.ToBase64String(bytes);
        Console.WriteLine("Nội dung đã được mã hóa.");
    }

    // Giải mã nội dung (từ chuỗi base64 về văn bản gốc)
    public void Decrypt()
    {
        byte[] bytes = Convert.FromBase64String(content);
        content = Encoding.UTF8.GetString(bytes);
        Console.WriteLine("Nội dung đã được giải mã.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Document doc = new Document();

        // Thiết lập nội dung
        doc.Data = "Nguyễn Quốc Khánh";

        // Ghi nội dung vào tệp
        doc.Write("document.txt");

        // Đọc nội dung từ tệp
        doc.Read("document.txt");

        // Mã hóa nội dung
        doc.Encrypt();

        // Ghi nội dung đã mã hóa vào tệp
        doc.Write("encrypted_document.txt");

        // Giải mã nội dung
        doc.Decrypt();

        // Ghi nội dung đã giải mã vào tệp
        doc.Write("decrypted_document.txt");
    }
}
