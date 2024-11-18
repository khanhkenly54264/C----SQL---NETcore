namespace lab08
{
    /// <summary>
    ///  chương trình minh họa việc sử dụng một số thao tác trên tập dữ liệu sử dụng câu lệnh LINQ
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            //khởi tạo tập dữ liệu
            string[] data = { "To", "ve", "hon", "nguoi", "thi", "nguoi", "se", "tro", "thanh", "ke", "thu", "cua", "ta", "Chiu", "nhuong", "nguoi", "thi", "nguoi", "se", "la", "ban", "cua", "ta" };
            //truy van du lieu
            IEnumerable<string> result1 = from m in data select m;
            //hien thi ket qua
            Console.WriteLine("Hien thi tat ca ket qua");
            foreach (var item in result1)
            {
                Console.Write(item + " ");
            }
            //truy van theo dieu kien lay cac tu la "nguoi"
            IEnumerable<string> result2 = from m in data
                                          where m.Equals("nguoi")
                                          select m;
            //hien thi ket qua
            Console.WriteLine("\nTruy van theo dieu kien");
            foreach (var item in result2)
            {
                Console.WriteLine(item + " ");
            }
            //sap xep du lieu
            IEnumerable<string> result3 = from m in data orderby m select m;
            //hien thi ket qua
            Console.WriteLine("Hien thi tat ca ket qua sap xep");
            foreach (var item in result3)
            {
                Console.Write(item + " ");
            }
            //lay tap du lieu moi
            var result4 = from m in data
                          select new
                          {
                              Thuong = m.ToLower(),
                              Hoa = m.ToUpper()
                          };
            //hien ti ket qua 
            Console.WriteLine("Chu thuong va hoa");
            foreach (var item in result4)
            {
                Console.WriteLine(item.Thuong + ":" + item.Hoa);
            }
        }
    }
}
