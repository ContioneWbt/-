using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPrinciple.OCP
{
    /// <summary>
    /// 开闭原则:对扩展开发，对修改关闭
    ///    修改：修改现有代码(类)
    ///    扩展：增加代码(类)
    /// 面向对象语言是一种静态语言，最害怕变化，会波及很多东西 全面测试
    /// 最理想就是新增类，对原有代码没有改动，原有的代码才是可信的
    /// 
    /// 开闭原则只是一个目标，并没有任何的手段，也被称之为总则
    ///     其他5个原则的建议，就是为了更好的做到OCP
    ///     开闭原则也是面向对象语言开发一个终极目标
    ///     
    /// 如果有功能增加/修改的需求：
    /// 修改现有方法---增加方法---增加类---增加/替换类库
    /// </summary>
    public class OCPShow
    {
        public static void Show()
        {
            Console.WriteLine("*************OCPShow***********");
       
        }
    }
}
