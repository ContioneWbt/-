using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPrinciple.DIP
{
    /// <summary>
    /// 依赖倒置原则:高层模块不应该依赖于低层模块，二者应该通过抽象依赖
    ///              依赖抽象，而不是依赖细节
    /// 抽象：接口/抽象类--可以包含没有实现的元素
    /// 细节：普通类--一切都是确定的
    /// 
    /// 面向抽象编程：尽量的使用抽象，80%的设计模式都是跟抽象有关
    /// 属性 字段  方法参数 返回值。。。尽量都是抽象
    /// 
    /// 
    /// </summary>
    public class DIPShow
    {
        public static void Show()
        {
            Console.WriteLine("**************DIPShow***************");
            Student student = new Student()
            {
                Id = 191,
                Name = "候鸟班长"
            };
            //Student-使用-手机
            //高层---------底层
            {
                iPhone phone = new iPhone();
                student.PlayiPhone(phone);
                student.PlayT(phone);
                student.Play(phone);
            }
            {
                Lumia phone = new Lumia();
                student.PlayLumia(phone);
                student.PlayT(phone);
                student.Play(phone);
            }
            {
                Honor phone = new Honor();
                student.PlayHonor(phone);
                student.PlayT(phone);
                student.Play(phone);
            }
            //依赖细节  高层就依赖了底层
            //手机扩展一下，学生就得改一下。。。手机多了怎么办
            {
                Mi phone = new Mi();
                student.PlayT(phone);
                student.Play(phone);
            }
            {
                Oppo phone = new Oppo();
                student.PlayT(phone);
                student.Play(phone);
            }
            //用泛型+父类约束其实就等同于用父类参数类型
            //面向抽象有啥好处？ 
            //1 一个方法满足不同类型的参数，
            //2 还支持扩展，只要是实现了这个抽象，不用修改Student
            {
                //面向抽象后，不能使用子类的特别内容
                Mi phone = new Mi();
                student.Play(phone);
                //如果传递的是Mi，Bracelet是有的，但是方法确实不能用
                //编译器决定了是不能用Bracelet的(dynamic/反射是可以调用的)

                //不能常规调用，这个问题是解决不了的，
                //因为面向抽象不止一个类型，用的就是通用功能；非通用的，那就不应该面向抽象
            }
            //面向抽象，只要抽象不变，高层就不变
            //面向对象语言开发，就是类与类之间进行交互，如果高层直接依赖低层的细节，细节是多变的，那么低层的变化就导致上层的变化；如果层数多了，底层的修改会直接水波效应传递到最上层，一点细微的改动都会导致整个系统从下往上的修改(这就是大家经常加班的原因)
            //面向抽象，如果高层和低层没有直接依赖，而是依赖于抽象，抽象一般是稳定的，那低层细节的变化扩展就不会影响到高层，这样就能支持层内部的横向扩展，不会影响其他地方，这样的程序架构就是稳定的

            //依赖倒置原则(理论基础)---IOC控制反转(实践封装)---DI依赖注入(实现IOC的手段)
        }
    }
}
