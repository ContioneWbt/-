using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPrinciple.SRP
{
    public abstract class AbstractAnimal
    {
        protected string _Name = null;
        public AbstractAnimal(string name)
        {
            this._Name = name;
        }

        public abstract void Breath();
        public abstract void Action();
    }
}
