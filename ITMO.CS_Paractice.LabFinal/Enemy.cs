using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ITMO.CS_Paractice.LabFinal
{
     class Enemy: Character
    {
        public double armor;
        public double meleeDamage;
        public Random Damage;

        public Enemy(double armor, double meleeDamage, string name,
            double HP, double level, double MaxHP) : base(name, HP, level, MaxHP)
        {
            this.armor = armor * (level * 1.35);
            this.meleeDamage = meleeDamage * (level * 1.25);
        }
        public override void TakeDamage(double damage)
        {
            HP -= damage - armor;
            if (HP <=0)
            {
                Die();
                HP = 0;
             }
            else

            Console.WriteLine($"{name} (Противник) получил {damage:F} урона. " +
                $"Текущее здоровье: {HP:F}");
            
        }
        public void Attack(Character target)
        {
            double damage = meleeDamage;
            /*int damage = Damage.Next(10, 21);*/ // Генерируем случайный урон
            Console.WriteLine($"{name} (Противник) атакует {target.name} на {damage} урона." +"\n");
            target.TakeDamage(damage);
        }

        new public void show()
        {
            base.show();
            Console.WriteLine($"Броня персонажа: {armor:F2}" + "\n" +
                              $"Урон оружием: {meleeDamage:F2}" + "\n");
        }
    }
}
