using PatterDesignStrategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatterDesignStrategy.Strategies
{
    class RobotWalkFast:IWalkBehavior
    {
        public void walk()
        {
            Console.WriteLine("Robot that walk fast");
        }
    }
}
