﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPrinciple.DIP
{
    public class Mi : AbstractPhone
    {
        public override void Call()
        {
            Console.WriteLine("User {0} Call", this.GetType().Name);
        }
        public override void Text()
        {
            Console.WriteLine("User {0} Text", this.GetType().Name);
        }

        public void Bracelet()
        {
            Console.WriteLine("User {0} Bracelet", this.GetType().Name);
        }
    }
}
