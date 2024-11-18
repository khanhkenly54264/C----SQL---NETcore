namespace Lab3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Contact ct1 = new Contact();
            ct1.Id = 6;
            ct1.Firstname = "Nguyen";
            ct1.Lastname = "Tuan Anh";
            ct1.Address = "Ha Noi";
            ct1.Email = "nta20030123@gmail.com";
            ct1.Phone = "0989846796";
            Contact ct2 = new Contact(5,"Dam","Quoc Dan","Bac Ninh","damquocdan@gmail.com", "0368966992") ;
            ct1.Display();
            ct2.Display();
           
        }
    }
}
