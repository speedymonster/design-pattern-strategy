using PatterDesignStrategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatterDesignStrategy.Object
{
    public abstract class Robot
    {
        protected IWalkBehavior _iwalkbehavior;
        protected IShootBehavior _ishootbehavior;
        public Robot()
        { }
        public void walk()
        {
            _iwalkbehavior.walk();
        }
        public void shoot()
        {
            _ishootbehavior.shoot();
        }

        public virtual void killeverybody()
        {

        }


    }
}
