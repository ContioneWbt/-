using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPrinciple.ISP
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //public void Pay(iPhone phone)
        //{
        //    Console.WriteLine("这里是{0}", this.Name);
        //    phone.Call();
        //    phone.Text();
        //}

        public void Video(IExtendVideo extend)
        {
            extend.Photo();
            extend.Movie();
        }

        //public void Happy(IExtendHappy extend)
        //{
        //    extend.Online();
        //    extend.Game();
        //}

        public void Happy(IExtendGame extend)
        {
            extend.Game();
        }
    }
}
