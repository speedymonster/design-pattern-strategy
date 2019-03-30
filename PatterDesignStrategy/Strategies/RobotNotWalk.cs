using PatterDesignStrategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatterDesignStrategy.Strategies
{
    class RobotNotWalk:IWalkBehavior
    {

        public void walk()
        {
            Console.WriteLine("I cant walk");
        }
    }
}
