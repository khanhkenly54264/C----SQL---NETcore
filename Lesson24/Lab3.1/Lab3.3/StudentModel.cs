using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._3
{
    internal class StudentModel
    {
        List<Student> lstStd;
        public StudentModel()
        {
            this.lstStd = new List<Student>{
                 new Student()
                {
                Id = 1,
                Name = "Nguyen",
                Age = 20,
                },

                new Student()
                {
                Id = 2,
                Name = "Tuan",
                Age = 20,
                },

                new Student()
                {
                Id = 3,
                Name = "Anh",
                Age = 22,
                },

                new Student()
                {
                Id = 4,
                Name = "Ha",
                Age = 21,
                },

                new Student()
                {
                Id = 5,
                Name = "Noi",
                Age = 21,
                },
        };
           
        }
        
        public List<Student> GetStudent()
        {
            return lstStd;
        }

        public Student GetStudent(int id)
        {
            Student std = null;
            foreach (var item in lstStd) 
            { 
                if(item.Id == id)
                {
                    std = item;
                } 
            }
            return std;
        }

        public List<Student> GetStudent(int x, int y)
        {
            List<Student> res = new List<Student>();
            foreach (var item in lstStd)
            {
                if(item.Age >= x && item.Age <= y) 
                { 
                    res.Add(item);
                }
            }
            return res;
        }
    }
}
