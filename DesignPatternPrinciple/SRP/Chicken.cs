using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPrinciple.SRP
{
    public class Chicken : AbstractAnimal
    {
        public Chicken(string name) : base(name)
        {
        }

        public Chicken() : base("鸡")
        {
        }

        public override void Breath()
        {
            Console.WriteLine($"{base._Name} 呼吸空气");
        }
        public override void Action()
        {
            Console.WriteLine($"{base._Name} flying");
        }
    }
}
