using PatterDesignStrategy.Object;
using PatterDesignStrategy.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatterDesignStrategy
{
    class RobotMilitar:Robot
    {
        public RobotMilitar()
        {
            _ishootbehavior = new RobotShotNormal();
            _iwalkbehavior = new RobotWalkFast();
        }
    }
}
