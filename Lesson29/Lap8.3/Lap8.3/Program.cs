
namespace lab_8._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //khai bao chung
            int[] Numbers = { 7, 9, 3, 5, 2, 1, 0, 6, 4, 3, 1 };
            string[] Words = { "Chỉ", "trích", "phê", "phán", "người", "khác", "giống", "như", "con", "chim", "bồ", "câu", "đưa", "thư", "bao", "giờ", "cũng", "quay", "về", "nơi", "xuất", "phát" };
            List<Film> ListFilm = new List<Film>()
            {
                new Film{FilmId="F01",FilmName="Điệp viên 007",Price=120000},
                new Film{FilmId="F02",FilmName="Tam quốc diễn nghĩa",Price=130000},
                new Film{FilmId="F03",FilmName="Thiếu lâm truyền kỳ",Price=160000},
                new Film{FilmId="F04",FilmName="Người nhện 2",Price=100000},
                new Film{FilmId="F05",FilmName="Ngân hàng tính yêu",Price=340000},
                new Film{FilmId="F06",FilmName="Người đẹp và quái thú",Price=230000},
                new Film{FilmId="F07",FilmName="Biệt động Sài Gòn",Price=190000},
            };
            //lọc các số chẵn

            IEnumerable<int> querynumber = Numbers.Where(n => n % 2 == 0); Show<int>(querynumber, "Loc cac so chan:");

            //lọc các từ có độ dài >4

            IEnumerable<string> queryword = Words.Where(w => w.Length > 4); Show<string>(queryword, "Loc cac tu co do dai >4:");

            //lọc các từ có tên bắt đầu bằng chữ t

            IEnumerable<string> queryT = Words.Where(w => w.StartsWith("t")); Show<string>(queryT, "Loc cac tu co ten bat dau bang chu t:");

            //Lọc các số duy nhất trong tập các số

            var uniqueNumber = Numbers.Distinct();

            Show<int>(uniqueNumber, "Loc cac so duy nhat trong tap cac so:");

            //Đếm xem có bao nhiêu từ không trùng nhau

            var countDistinct = Words.Distinct().Count();

            Console.WriteLine("Dem xem co bao nhieu tu khong trung nhau:" +

            countDistinct);

            //lấy 4 số đầu tiên trong dãy

            var fourNumber = Numbers.Take(4);

            Show<int>(fourNumber, "Lay 4 so dau tien trong day:");

            //lấy 2 từ đầu tiên trong câu

            var twoword = Words.Take(2);

            Show<string>(twoword, "Lay 2 tu dau tien trong cau:");
            // lấy những từ đầu tiên có chứa chữ t

            var searchword = Words.TakeWhile(w => w.Contains('t'));

            Show<string>(searchword, "Lay nhung tu dau tien co chua chu t:");

            //sắp xếp theo đơn giá, lấy những phim đầu tiên có đơn giá <200000

            var queryfilm = ListFilm.OrderBy(f => f.Price)

            .Select(x => new { x.FilmId, x.FilmName, x.Price })

            .ToList().TakeWhile(t => t.Price < 200000);

            //bỏ qua 3 phần từ đầu tiên, lấy tất cả các phân tử còn lại

            var skipNumber = Numbers.Skip(3);
            Show<int>(skipNumber, "Bo qua 3 phan tu dau tien, lay tat ca cac phan tu con lai:");
            //bỏ qua 4 phần tử đầu tiên lấy 3 phần tử kế tiếp
            var skipTakeNumber = Numbers.Skip(4).Take(3);
            Show<int>(skipTakeNumber, "bo qua 4 phan tu dau tien, lay 3 phan tu ke tiep:");
            //bỏ qua 3 phím đầu tiên lấy 3 phím kế tiếp(có thể áp dụng phân trang)
            var skipTakeFilm = ListFilm.Skip(3).Take(3);
            Show<Film>(skipTakeFilm, "bo qua 3 phim dau tien, lay 3 phim ke tiep:");
            //sắp xếp giảm dần, sau đó lấy các phần tử <5
            var sortNumber = Numbers.OrderByDescending(x => x).SkipWhile(x => x > 5);
            Show<int>(sortNumber, "Sap xep giam dan, sau do lay cac phan tu <5:");
        }
        //định nghĩa phương thức Gểnic hiển thị dữ liệu
        static void Show<T>(IEnumerable<T> data, string message)
        {
            Console.WriteLine(message);
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
        }

    }
}
