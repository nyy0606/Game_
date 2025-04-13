using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_1
{
    public enum PlayerType
    {
        None = 0,
        Knight = 1,
        Archer = 2,
        Mage = 3
    }

    class Player : Creature
    {
        protected PlayerType type = PlayerType.None;

        protected Player(PlayerType type) : base(CreatureType.Player)
        {
            this.type = type;
        }
    }

    class Knight : Player
    {
        public Knight() : base(PlayerType.Knight) 
        {
            Setinfo(100, 10);
        }
    }

    class Archer : Player
    {
        public Archer() : base(PlayerType.Archer)
        {
            Setinfo(75, 12);
        }
    }

    class Mage : Player
    {
        public Mage() : base(PlayerType.Mage)
        {
            Setinfo(50, 20);
        }
    }
}
