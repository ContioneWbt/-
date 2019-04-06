using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPrinciple.ISP
{
    public interface IExtend
    {
        //void Photo();
        //void Online();
        //void Game();
        void Record();
        //void Movie();
        void Map();//
        void Pay();
    }//都拆成一个方法一个接口


    //电视--上网 玩游戏
    public interface IExtendHappy : IExtendGame
    {
        void Online();
        //void Game();
    }
    //掌中游戏机：俄罗斯方块--玩游戏不能上网

    public interface IExtendGame
    {
        void Game();
    }

    public interface IExtendVideo
    {
        void Photo();
        void Movie();//打开相机--切换模式--start--Suspend--End
    }
}
