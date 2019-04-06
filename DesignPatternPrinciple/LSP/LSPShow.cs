using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPrinciple.LSP
{
    /// <summary>
    /// 里氏替换原则：任何使用基类的地方，都可以透明的使用其子类
    /// 继承、多态
    /// 继承：子类拥有父类的一切属性和行为，任何父类出现的地方，都可以用子类来代替
    /// 继承+透明(安全，不会出现行为不一致)
    /// 
    /// 1 父类有的，子类是必须有的；
    ///   如果出现了子类没有的东西，那么就应该断掉继承；
    ///   (再来一个父类，只包含都有的东西)
    /// 2 子类可以有自己的属性和行为
    ///   子类出现的地方，父类不一定能代替
    ///   白马非马
    /// 3 父类实现的东西，子类就不要再写了，(就是不要new隐藏)
    ///   有时候会出现意想不到的情况，把父类换成子类后，行为不一致
    ///   如果想修改父类的行为，通过abstract/virtual
    ///   
    /// 声明属性、字段、变量，尽量声明为父类(父类就能满足)
    /// 
    /// </summary>
    public class LSPShow
    {
        public static void Show()
        {
            Console.WriteLine("***************************");
            Poly.Test();
            {
                //People people = new Chinese();
                Chinese people = new Chinese();
                people.Traditional();
                //DoChinese(people);
                people.SayHi();
            }
            {
                Chinese people = new Hubei();
                people.Traditional();
                //DoChinese(people);
                people.SayHi();

            }
            {
                var people = new Hubei();
                people.Traditional();
                //DoChinese(people);
                people.SayHi();
            }
            {
                People people = new Japanese();
                people.Traditional();
                //要么上端调用去判断  不能写  因为Japanese没有Traditional
                //要么就只能在子类抛异常
            }
            {
                Hubei people = new Hubei();
                people.Traditional();
                DoChinese(people);
                DoHubei(people);
            }

            {
                //People people = new People();
                //Do(people);
            }

        }

        private static void DoChinese(Chinese people)
        {
            Console.WriteLine($"{people.Id} {people.Name} {people.Kuaizi}");
            people.SayHi();
        }



        private static void DoHubei(Hubei people)
        {
            Console.WriteLine($"{people.Id} {people.Name} {people.Kuaizi}");
            people.SayHi();
        }

    }
}
