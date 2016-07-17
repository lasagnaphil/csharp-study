using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4
{
    public class Creature
    {
        public int Hp { get; set; }
        public int Damage { get; set; }

        public void Attack(Creature creature)
        {
            creature.Hp -= Damage;
        }

        public Creature() : this(100, 0) { }
        public Creature(int hp, int damage)
        {
            Hp = hp;
            Damage = damage;
        }
    }

    public class Player : Creature
    {
        public int Money { get; private set; }

        public Player() : this(200, 20, 100) { }
        public Player(int hp, int damage, int money) : base(hp, damage)
        {
            Money = money;
        }
    }

    public class Magician : Creature
    {
        public int Mp { get; set; }
        public Magician() : this(100, 10, 200) { }
        public Magician(int hp, int damage, int mp) : base(hp, damage)
        {
            Mp = mp;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Creature creature = new Player(100, 20, 1000);

            Console.WriteLine(creature.Hp);
            Console.WriteLine(creature.Damage);

            Player player = (Player)creature;
            Console.WriteLine(player.Money);

            Magician magician = (Magician) creature;
            Console.WriteLine(magician.Mp);

            string scoreStr = "100";
            int score = (int) scoreStr;
        }
    }
}
