using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPrinciple.LSP
{
    public class People
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //abstract void Eat();
        public void Traditional()
        {
            Console.WriteLine("仁义礼智信 温良恭俭让 ");
        }
    }

    public class Chinese : People
    {
        public string Kuaizi { get; set; }
        public void SayHi()
        {
            Console.WriteLine("早上好，吃了吗？");
        }

    }

    public class Hubei : Chinese
    {
        public string Majiang { get; set; }
        public new void SayHi()
        {
            Console.WriteLine("早上好，过早了么？");
        }
    }

    //public class Animal//让People继承自Animal
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}

    public class Japanese : People
    {
        //public int Id { get; set; }
        //public string Name { get; set; }
        //public new void Traditional()
        //{
        //    Console.WriteLine("忍者精神 ");
        //throw new Exception();
        //}
        //Traditional也会继承 但是Japanese又没有Traditional
        public void Ninja()
        {
            Console.WriteLine("忍者精神 ");
        }

    }

}
