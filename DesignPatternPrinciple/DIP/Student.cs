using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPrinciple.DIP
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        /// <summary>
        /// 依赖细节  高层就依赖了底层
        /// </summary>
        /// <param name="phone"></param>
        public void PlayiPhone(iPhone phone)
        {
            Console.WriteLine("这里是{0}", this.Name);
            phone.Call();
            phone.Text();
        }

        public void PlayLumia(Lumia phone)
        {
            Console.WriteLine("这里是{0}", this.Name);
            phone.Call();
            phone.Text();
        }

        public void PlayHonor(Honor phone)
        {
            Console.WriteLine("这里是{0}", this.Name);
            phone.Call();
            phone.Text();
        }

        public void PlayHonor(Mi phone)
        {
            Console.WriteLine("这里是{0}", this.Name);
            phone.Call();
            phone.Text();

            phone.Bracelet();//要用手环功能
        }
        public void Play(AbstractPhone phone)
        {
            Console.WriteLine("这里是{0}", this.Name);
            phone.Call();
            phone.Text();

            //phone.Bracelet();
        }







        public void PlayT<T>(T phone) where T : AbstractPhone
        {
            Console.WriteLine("这里是{0}", this.Name);
            phone.Call();
            phone.Text();
        }
    }
}
