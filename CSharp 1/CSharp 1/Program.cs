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

    class Player // 부모 클래스 혹은 기반 클래스
    {
        static public int counter = 1; // static을 사용하면 각 인스턴스가 아니라 Knight 종속, 오로지 한개만 존재
        public int id;
        public int hp;
        public int attack;

        public Player()
        {
            Console.WriteLine("Player 생성자 호출");
        }

        public Player(int hp)
        {
            this.hp = hp;
            Console.WriteLine("Player hp 생성자 호출");
        }

        public void Move()
        {
            Console.WriteLine("Move");
        }

        public void Attack()
        {
            Console.WriteLine("Attack");
        }
    }


    class Mage : Player // 자식 혹은 파생
    {

    }

    class Archer : Player
    {

    }


    class Knight : Player
    {
       
    }

    


	class Program
	{
        static void Main(string[] args)
        {
            Knight knight = new Knight();
            knight.Move();

        }
    }
}
  