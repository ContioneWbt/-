using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPrinciple.ISP
{
    /// <summary>
    /// 接口隔离原则:客户端不应该依赖它不需要的接口；
    ///              一个类对另一个类的依赖应该建立在最小的接口上；
    /// </summary>
    public class ISPShow
    {
        public static void Show()
        {
            Console.WriteLine("***************ISPShow*************");
            Student student = new Student()
            {
                Id = 191,
                Name = "候鸟班长"
            };
            //AbstractPhone定义了id branch call text    is  a
            //现有智能手机map movie online game..
            //是否该把这几个上升到AbstractPhone? 
            //不应该的，上升后，oldman也是手机，但是没有这些功能！
            //AbstractPhone就只能放入任何手机都必须具备的功能
            {
                OldMan phone = new OldMan();
                phone.Call();
                phone.Text();
            }
            //不适合放在抽象类，但是面向抽象编程，接口！
            //接口interface定义 can do   不局限产品
            //Camera能拍照，能录像
            //既然面向抽象，那么有这些功能的对象都得能传递进来
            //那就让Camera也去实现IExtend
            {
                Honor honor = new Honor();
                student.Happy(honor);
                student.Video(honor);
            }
            {
                Camera camera = new Camera();
                student.Video(camera);
            }
            //实现IExtend接口，Camera出现很多自己没有的功能,
            //不应该用这种大而全的接口
            {
                IExtendVideo camera = new Camera();
                student.Video(camera);
            }

            {
                IExtendHappy extend = new TV();
                student.Happy(extend);
            }
            {
                IExtendGame extend = new PSP();
                student.Happy(extend);
            }
            //拆下去，都拆成一个方法一个接口，肯定也不好！
            {
                //List<>
                //Dictionary
                //IList<T>        索引相关
                //ICollection<T>  集合相关操作
                //IEnumerable<T>  迭代器foreach
            }
            //接口到底该如何定义？  
            //1 既不能是大而全，会强迫实现没有的东西，也会依赖自己不需要的东西
            //2 也不能一个方法一个接口，这样面向抽象也没有意义的
            //按照功能的密不可分来定义接口，
            //而且应该是动态的，随着业务发展会有变化的，但是在设计的时候，要留好提前量，避免抽象的变化
            //没有标准答案，随着业务和产品来调整的

            //3 接口合并 Map--定位/搜索/导航   这种属于固定步骤，业务细节，尽量的内聚，在接口也不要暴露太多业务细节
        }
    }
}
