using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheQuest
{
    class Ghoul :Enemy
    {
        public Ghoul(Game game, Point location) 
            : base(game, location, 10)
        {
        }
        public override void Move(Random random)
        {
            if (random.Next(1, 3) % 2 == 0 )
            {
                location = location;
            }
            else
            {
                location = Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);
            }
            if (NearPlayer())
            {
                game.HitPlayer(4, random);
            }

        }
    }
}
