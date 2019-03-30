using PatterDesignStrategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatterDesignStrategy.Strategies
{
    class RobotNotShoot:IShootBehavior
    {
        public void shoot()
        {
            Console.WriteLine("I can't shoot");
        }
    }
}
