using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPrinciple.SRP
{
    public class Fish : AbstractAnimal
    {
        public Fish() : base("鱼")
        {
        }

        public override void Breath()
        {
            Console.WriteLine($"{base._Name} 呼吸水");
        }
        public override void Action()
        {
            Console.WriteLine($"{base._Name} swimming");
        }
    }
}
