using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPrinciple.SRP
{
    /// <summary>
    /// 单一职责原则：类T负责两个不同的职责：职责P1，职责P2。当由于职责P1需求发生改变而需要修改类T时，
    /// 有可能会导致原本运行正常的职责P2功能发生故障。
    /// 
    /// 一个类只负责一件事儿
    /// 面向对象语言开发，类是一个基本单位，单一职责原则就是封装的粒度
    /// 
    /// 写分支判断，然后执行不同的逻辑，其实这就违背了单一职责原则，但是功能是可以实现的
    /// 
    /// 拆分父类+子类，
    /// 每个类很简单，简单意味着稳定 意味着强大
    /// (现在的东西没有以前经用，因为功能多了，这不坏那坏了)
    /// 
    /// 拆分后，也会造成代码量的增加，
    /// 类多了，使用成本也高(理解成本)
    /// 
    /// 究竟该什么时候使用单一职责原则呢？
    /// 如果类型足够简单，方法够少，是可以在类级别去违背单一职责
    /// 如果类型复杂了，方法多了，建议遵循单一职责原则
    /// 
    /// 方法级别的单一职责原则：一个方法只负责一件事儿（职责分拆小方法，分支逻辑分拆）
    ///   类级别的单一职责原则：一个类只负责一件事儿
    /// 类库级别的单一职责原则：一个类库应该职责清晰
    /// 项目级别的单一职责原则：一个项目应该职责清晰(客户端/管理后台/后台服务/定时任务/分布式引擎)
    /// 系统级别的单一职责原则：为通用功能拆分系统(IP定位/日志/在线统计)
    /// 
    /// </summary>
    public class SRPShow
    {
        public static void Show()
        {
            {
                Animal animal = new Animal("鸡");//呼吸空气
                animal.Breath();
                //animal.Action();
            }
            {
                Animal animal = new Animal("牛");//呼吸空气
                animal.Breath();
                //animal.Action();
            }
            {
                Animal animal = new Animal("鱼");//呼吸水
                animal.Breath();
                animal.Action();
            }
            {
                AbstractAnimal animal = new Chicken();
                animal.Breath();
                animal.Action();
            }
            {
                AbstractAnimal animal = new Fish();
                animal.Breath();
                animal.Action();
            }
        }
    }
}
