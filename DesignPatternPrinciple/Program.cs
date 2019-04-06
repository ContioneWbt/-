using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPrinciple
{
    /// <summary>
    /// 1.  单一职责原则（Single Responsibility Principle）
    /// 2.  里氏替换原则（Liskov Substitution Principle）
    /// 3.  依赖倒置原则（Dependence Inversion Principle）
    /// 4.  接口隔离原则（Interface Segregation Principle）
    /// 5.  迪米特法则  （Law Of Demeter）
    /// 6.  开闭原则    （Open Closed Principle)
    /// 
    /// 设计模式：面向对象语言开发过程中，遇到种种的场景和问题，提出的解决方案和思路，沉淀下来
    ///           设计模式是解决具体问题的套路
    /// 设计模式六大原则：面向对象语言开发过程中，推荐的一些指导性原则
    ///                   没有明确的招数，而且也经常会被忽视/违背
    ///                   也是前辈总结，也是为了站在前辈的肩膀上
    ///                   
    /// 实际上真实项目很难全部遵循，更多的时候会有一些侧重性
    /// 设计模式六大原则要能灵活应用，离不开实践的锤炼和思考，把这个真的融入到骨子里面去了，设计确实会不一样的
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("设计模式六大原则");
                {
                    //Console.WriteLine("*******************单一职责原则********************");
                    //SRP.SRPShow.Show();
                }
                {
                    //Console.WriteLine("*******************里氏替换原则********************");
                    //LSP.LSPShow.Show();
                }
                {
                    //Console.WriteLine("*******************依赖倒置原则********************");
                    //DIP.DIPShow.Show();
                }
                //{
                //    Console.WriteLine("*******************接口隔离原则********************");
                //    ISP.ISPShow.Show();
                //}
                //{
                //    Console.WriteLine("*******************迪米特法则********************");
                //    LOD.LODShow.Show();
                //}
                //{
                //    Console.WriteLine("*******************里氏替换原则********************");
                //    OCP.OCPShow.Show();
                //}
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Read();
        }
    }
}
//静态类：静态方法不占内存  静态字段--唯一的占据内存 不会释放的
