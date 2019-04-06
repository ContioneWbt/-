using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPrinciple.SRP
{
    /// <summary>
    /// 封装
    /// 动物类
    /// 简单意味着稳定
    /// </summary>
    public class Animal
    {
        private string _Name = null;
        public Animal(string name)
        {
            this._Name = name;
        }
        /// <summary>
        /// 这个方法就挺不稳定，经常各种分支变化经常修改
        /// </summary>
        public void Breath()
        {
            if (this._Name.Equals("鸡"))
                Console.WriteLine($"{this._Name} 呼吸空气");
            else if (this._Name.Equals("牛"))
                Console.WriteLine($"{this._Name} 呼吸空气");
            else if (this._Name.Equals("鱼"))
                Console.WriteLine($"{this._Name} 呼吸水");
            else if (this._Name.Equals("蚯蚓"))
                Console.WriteLine($"{this._Name} 呼吸泥土");
        }
        //BreathChicken  BreathFish

        //应该拆分了
        public void Action()
        {
            if (this._Name.Equals("鸡"))
                Console.WriteLine($"{this._Name} flying");
            else if (this._Name.Equals("牛"))
                Console.WriteLine($"{this._Name} walking");
            else if (this._Name.Equals("鱼"))
                Console.WriteLine($"{this._Name} Swimming");
            else if (this._Name.Equals("蚯蚓"))
                Console.WriteLine($"{this._Name} Crawling");
        }
    }
}
