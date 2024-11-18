namespace Lab6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<string,string> lstSrt = new SortedList<string,string>();
            lstSrt.Add("E01", "Nguyen Tuan Anh");
            lstSrt.Add("E02", "Le Hai Ha");
            lstSrt.Add("E03", "Nguyen Van Hung");
            lstSrt.Add("E04", "Hoang Thi Van Thom");
            lstSrt.Add("E05", "Trinh Van Chien");
            Console.WriteLine("Danh sach nhan vien");
            foreach (var srt in lstSrt.Keys) 
            {
                Console.WriteLine(srt + ":" + lstSrt[srt]);
            }
            Console.WriteLine("Danh sach nhan vien bat dau bang chu Th");
            foreach(var srt in lstSrt.Keys) 
            {
                if (lstSrt[srt].StartsWith("Th"))
                Console.WriteLine(srt + ":" + lstSrt[srt]);
            }
            lstSrt.Remove("E04");
            if (!lstSrt.ContainsKey("E06"))
                lstSrt.Add("E06", "Nguyen Hoai Linh");
            Console.WriteLine("Danh sach nhan vien sau khi xoa, them");
            foreach( var srt in lstSrt.Keys)
            {
                Console.WriteLine(srt + ":" + lstSrt[srt]);
            }
        }
    }
}
