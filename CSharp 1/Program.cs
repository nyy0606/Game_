using System.Data;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using System.Threading.Channels;

namespace CSharp_1
{
	class Program
	{
         
        enum ClassType
        {
            None = 0,
            Knight = 1,
            Archer = 2,
            Mage = 3
        }

        struct Player
        {
            public int hp;
            public int attack;
        }

        enum MonsterType
        {
            None = 0,
            Slime = 1,
            Orc = 2,
            Skeleton = 3
        }

        struct Monster
        {
            public int hp;
            public int attack;
        }
            //랜덤으로 1~3번 몬스터 중 하나를 소환

        static ClassType ChooseClass()
        {
            Console.WriteLine("직업을 선택하세요");
            Console.WriteLine("[1] 기사");
            Console.WriteLine("[2] 궁수");
            Console.WriteLine("[3] 법사");

            ClassType choice = ClassType.None;

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    choice = ClassType.Knight;
                    Console.WriteLine("기사");
                    break;
                case "2":
                    choice = ClassType.Archer;
                    Console.WriteLine("궁수");
                    break;
                case "3":
                    choice = ClassType.Mage;
                    Console.WriteLine("법사");
                    break;
            }
            return choice;
        }

        static void CreatePlayer(ClassType choice, out Player player)
        {
            

            switch (choice)
            {
                case ClassType.Knight:
                    player.hp = 100;
                    player.attack = 10;
                    break;
                case ClassType.Archer:
                    player.hp = 75;
                    player.attack = 12;
                    break;
                case ClassType.Mage:
                    player.hp = 50;
                    player.attack = 15;
                    break;
                default:
                    player.hp = 0;
                    player.attack = 0;
                    break;
            }
            
        }

        static void CreateRandomMonster(out Monster monster)
        {
            Random rand = new Random();
            int RandMonster = rand.Next(1, 4);
            switch (RandMonster)
            {
                case (int)MonsterType.Slime:
                    Console.WriteLine("슬라임 스폰");
                    monster.hp = 20;
                    monster.attack = 2;
                    break;
                case (int)MonsterType.Orc:
                    Console.WriteLine("오크 스폰");
                    monster.hp = 40;
                    monster.attack = 4;
                    break;
                case (int)MonsterType.Skeleton:
                    Console.WriteLine("스켈레톤 스폰");
                    monster.hp = 30;
                    monster.attack = 3;
                    break;
                default:
                    monster.hp = 0;
                    monster.attack = 0;
                    break;
            }
        }

        static void Fight(ref Player player, ref Monster monster)
        {
            while (true)
            {
                monster.hp -= player.attack;
                if (monster.hp <= 0)
                {
                    Console.WriteLine("승리");
                    Console.WriteLine($"남은 체력 : {player.hp}");
                    break;
                }

                player.hp -= monster.attack;
                if (player.hp <= 0)
                {
                    Console.WriteLine("패배");
                    Console.WriteLine($"적의 남은 체력 : {monster.hp}");
                    break;
                }
            }
        }

        static void EnterField(ref Player player)
        {
            while (true)
            {
                Console.WriteLine("필드 접속");

                Monster monster;
                CreateRandomMonster(out monster);

                Console.WriteLine("[1] 전투모드로 돌입");
                Console.WriteLine("[2] 일정 확률로 마을로 도망");


                string input = Console.ReadLine();
                if (input == "1")
                {
                    Fight(ref player, ref monster);
                }
                else if (input == "2")
                {
                    Random rand = new Random();
                    int randValue = rand.Next(0, 101);

                    if (randValue <= 33)
                    {
                        Console.WriteLine("탈출 성공");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("도망 실패 \n전투 시작");
                        Fight(ref player, ref monster);
                    }
                }
            }
        }

        static void EnterGame(ref Player player)
        {
            while (true)
            {

                Console.WriteLine("접속완료");
                Console.WriteLine("[1] 필드로 이동");
                Console.WriteLine("[2] 로비로 이동"); // 직업부터 다시 정하기 

                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        EnterField(ref player);
                        break;
                    case "2":
                        return;
                    
                        
                }
            }
        }

        static void Main(string[] args)
		{
            while (true)
            {
                ClassType choice = ChooseClass();
                //if(choice != ClassType.None)
                //{
                //    Player player; //캐릭터 생성 
                    
                //    CreatePlayer(choice, out player);

                //    EnterGame(ref player);
                //}

                if (choice == ClassType.None)
                {
                    continue;
                }
                Player player; //캐릭터 생성 

                CreatePlayer(choice, out player);

                EnterGame(ref player);




            }


        }   
    }
}
  