namespace Lab3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentModel model = new StudentModel();
            List<Student> getAll = model.GetStudent();
            foreach (var item in getAll) 
            {
                item.Display();
            }
            Student st = model.GetStudent(2);
            st.Display();
            List<Student> lstAge = model.GetStudent(20,21);
            foreach (var item in lstAge)
            {
                item.Display();
            }
        }
    }
}
