using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPrinciple.ISP
{
    public class PSP : IExtendGame
    {
        public void Game()
        {
            Console.WriteLine("User {0} Game", this.GetType().Name);
        }
    }
}
