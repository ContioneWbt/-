using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPrinciple.LOD
{
    /// <summary>
    /// 学生
    /// </summary>
    public class Student
    {
        public int Id { get; set; }
        public string StudentName { get; set; }
        public int Height { private get; set; }

        public int Salay;

        public void ManageStudent()
        {
            Console.WriteLine(" {0}Manage {1} ", this.GetType().Name, this.StudentName);
        }
    }
}
