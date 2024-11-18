using System;

/// <summary>
/// Tạo mảng CAN
/// Tạo mảng CHI
/// Theo lịch âm thì mỗi năm ứng với CAN + CHI
/// nHẬP 1 NĂM BẤT KỲ VÀ IN RA NĂM ÂM TƯƠNG ỨNG, 
/// CÓ THỂ ĐỔI CỊ TRÍ BẮT ĐẦU CỦA CAN VÀ CHI CHO PHÙ HỢPP.
/// VÍ DỤ BẮT ĐẦU NĂM 2010 LÀ NĂM CANH DẦN.
/// </summary>
class ChuongTrinh
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Default;
        // Mảng CAN và CHI
        string[] CAN = { "Giáp", "Ất", "Bính", "Đinh", "Mậu", "Kỷ", "Canh", "Tân", "Nhâm", "Quý" };
        string[] CHI = { "Tí", "Sửu", "Dần", "Mão", "Thìn", "Tỵ", "Ngọ", "Mùi", "Thân", "Dậu", "Tuất", "Hợi" };

        // Năm 2010 là năm Canh Dần (CAN[6] + CHI[2])
        int namCanChi2010 = 2010;

        // Nhập vào năm cần tìm
        Console.Write("Nhập vào năm dương lịch cần tra: ");
        int namNhapVao = int.Parse(Console.ReadLine());

        // Tính chỉ số CAN và CHI
        int chiSoCan = (namNhapVao - namCanChi2010 + 6) % 10; // 6 là chỉ số của "Canh" trong CAN
        int chiSoChi = (namNhapVao - namCanChi2010 + 2) % 12; // 2 là chỉ số của "Dần" trong CHI

        if (chiSoCan < 0) chiSoCan += 10;
        if (chiSoChi < 0) chiSoChi += 12;

        // In ra kết quả
        string namAmLich = CAN[chiSoCan] + " " + CHI[chiSoChi];
        Console.WriteLine("Năm âm lịch tương ứng: " + namAmLich);
    }
}
