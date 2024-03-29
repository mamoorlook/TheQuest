﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheQuest
{
    class Ghost : Enemy
    {
        public Ghost(Game game, Point location) 
            : base(game, location, 8)
        {
        }

        public override void Move(Random random)
        {
            if (random.Next(1, 3) % 2 == 0 )
            {
                location = Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);
            }
            if (NearPlayer())
            {
                game.HitPlayer(3, random);
            }

        }
    }
}
