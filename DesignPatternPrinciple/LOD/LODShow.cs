using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPrinciple.LOD
{
    /// <summary>
    /// 迪米特法则(最少知道原则):一个对象应该对其他对象保持最少的了解。
    /// 只与直接的朋友通信。
    /// 面向对象语言---万物皆对象---类和类交互才能产生功能--这不就耦合了吗？
    /// 
    /// 类与类之间的关系：
    /// 纵向：继承≈实现(最密切)
    /// 横向：聚合> 组合> 关联> 依赖(出现在方法内部)
    /// 
    /// 高内聚低耦合
    /// 迪米特法则，降低类与类之间的耦合
    ///     只与直接的朋友通信，就是要尽量避免依赖更多类型
    /// 基类库(BCL--框架内置的)的类型除外     
    ///
    /// 迪米特，也会增加一些成本
    /// 
    /// 工作中有时候会去造一个中介/中间层
    /// 门面模式 中介者模式  分层封装
    /// 上层UI下订单---订单系统&支付系统&仓储&物流
    /// 门面模式--上层交互门面--门面依赖子系统
    /// 三层架构：UI---BLL---DAL
    /// 
    /// 去掉内部依赖
    /// 降低访问修饰符权限
    /// private
    /// protected
    /// internal
    /// protected internal 子类或者同类库
    /// public
    /// 
    /// 迪米特,依赖别人更少，让别人了解更少
    /// </summary>
    public class LODShow
    {
        public static void Show()
        {
            Console.WriteLine("************************");
            School school = new School()
            {
                SchoolName = "软谋教育",
                ClassList = new List<Class>()
                {
                    new Class()
                    {
                        ClassName="高级班",
                        StudentList=new List<Student>()
                        {
                            new Student()
                            {
                                StudentName="Tony"
                            },
                            new Student()
                            {
                                StudentName="风尘浪子"
                            }
                        }
                    }
                }
            };

            school.Manage();
        }
    }
}
