using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPrinciple.LOD
{
    /// <summary>
    /// 班级
    /// </summary>
    public class Class
    {
        public int Id { get; set; }
        public string ClassName { get; set; }

        public List<Student> StudentList { get; set; }


        public void ManageClass()
        {
            Console.WriteLine(" {0}Manage {1} ", this.GetType().Name, this.ClassName);
            foreach (Student s in this.StudentList)
            {
                s.ManageStudent();
                //Console.WriteLine(" {0}Manage {1} ", s.GetType().Name, s.StudentName);
            }

        }


    }
}
