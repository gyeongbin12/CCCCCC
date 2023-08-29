using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Fighter
    {
        
        string shape;

        private int bulletCount;
        private Bullet[] bullet;

        public Fighter()
        {
            bulletCount = 5;
            bullet =  new Bullet[bulletCount];
        }
    }
}
