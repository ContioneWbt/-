using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPrinciple.ISP
{
    /// <summary>
    /// 可以拍照photo   录视频Movie
    /// </summary>
    public class Camera : IExtendVideo
    {
        public void Photo()
        {
            Console.WriteLine("User {0} Photo", this.GetType().Name);
        }
        public void Movie()
        {
            Console.WriteLine("User {0} Movie", this.GetType().Name);
        }

        //public void Online()
        //{
        //    throw new NotImplementedException();
        //}

        //public void Game()
        //{
        //    throw new NotImplementedException();
        //}

        //public void Record()
        //{
        //    throw new NotImplementedException();
        //}

        //public void Map()
        //{
        //    throw new NotImplementedException();
        //}

        //public void Pay()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
