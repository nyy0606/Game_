using System.Data;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using System.Threading.Channels;

namespace CSharp_1
{
    //객체(OOP Object Oriented Programming)
    
    //knight
    //속성 : hp, attack, position
    //기능 : Move, Attack, Die

    class Knight
    {
        public int hp;
        public int attack;
        
        public Knight Clone()
        {
            Knight knight = new Knight();
            knight.hp = hp;
            knight.attack = attack;

            return knight;
        }

        public void Move()
        {
            Console.WriteLine("Knight Move");
        }
        
        public void Attack()
        {
            Console.WriteLine("Knight Attack");
        }
    }

    struct Mage
    {
        public int hp;
        public int attack;
    }

    //class는 ref 참조, struct는 복사


	class Program
	{
        static void KillMage(Mage mage)
        {
            mage.hp = 0;
        }

        static void KillKnight(Knight knight)
        {
            knight.hp = 0;
        }

        static void Main(string[] args)
        {
            Mage mage;
            mage.hp = 100;
            mage.attack = 50;
            KillMage(mage);

            Mage mage2 = mage;
            mage2.hp = 0;
            

            Knight knight = new Knight();
            knight.hp = 100;
            knight.attack = 10;


            Knight knight2 = knight.Clone();
            


        }
    }
}
  