using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fedotovgame
{
    class Program
    {
        static void Main(string[] args)
        {

            // string hello = "Hello";
            // string world = "World";
            //Console.WriteLine(hello + " " + world);
            // Console.ReadLine();


            // int shish = 2;
            //int eshkere = 5;
            // Console.WriteLine(shish + eshkere);
            // Console.WriteLine(shish - eshkere);
            //Console.WriteLine(shish * eshkere);
            //Console.WriteLine(shish / eshkere);

            // Console.ReadLine();



            // Console.Write("Введите имя: ");
            // string name = Console.ReadLine();
            //Console.Write("Введите фамилию: ");
            // string surname = Console.ReadLine();
            // Console.Write("Введите отчество: ");
            //string otchestvo = Console.ReadLine();
            // Console.WriteLine($"Привет , {name} {surname} {otchestvo}");
            // Console.ReadLine();
        }
        public class Player
        {
            public string name;
            public int health;
            public int damage;
            public int armour;

            public Player(string name, int health, int damage, int armour)
            {
                this.name = name;
                this.health = health;
                this.damage = damage;
                this.armour = armour;

            }
            public void Attack(Monster monster);
            {

            int finalDamage = Math.Max(damage - monster.armour, 0);
            monster.health -= final.Damage;
                Console.WriteLine($" {name} deals {finalDamage} damage to {monster.name}.");
           }
    }
    public class Monster
    {
        public string name;
        public int health;
        public int damage;
        public int armor;

        public Monster(string name, int health, int damage, int armor)
        {
            this.name = name;
            this.health = health;
            this.damage = damage;
            this.armour = armour;
        }
    }
    public void Attack(Player player)
    {
        int finalDamage = Math.Max(damage - player.armour, 0);
        player.health -= final.Damage;
        Console.WriteLine($" {name} deals {finalDamage} damage to {player.name}.");

    }
}


Player player = new;






        }
    }

