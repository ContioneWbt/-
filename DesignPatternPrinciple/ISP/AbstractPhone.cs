using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPrinciple.ISP
{
    public abstract class AbstractPhone
    {
        public int Id { get; set; }
        public string Branch { get; set; }
        public abstract void Call();
        public abstract void Text();
        public void Show()
        { }

        //public abstract void Photo();
    }

    /// <summary>
    /// 一个大而全的接口
    /// </summary>
    //public interface IExtend
    //{
    //    void Photo();
    //    void Online();
    //    void Game();
    //    void Record();
    //    void Movie();
    //    void Map();
    //    void Pay();
    //}
}
