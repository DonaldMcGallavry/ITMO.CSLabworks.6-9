using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace ITMO.CS_Paractice.LabFinal
{
     class Warrior : Character
    {
        public double armor;
        public double meleeDamage;

        public Warrior(double armor, double meleeDamage, string name, 
            double HP, double level, double MaxHP) : base(name, HP, level, MaxHP)
        {
            this.armor = armor*(level*1.35);
            this.meleeDamage = meleeDamage*(level*1.25);
        }

        public override void TakeDamage(double damage)
        {
            HP -= damage - armor;
            if (HP <= 0)
            {
                Die();
                HP = 0;
            }
            else
                Console.WriteLine($"{name} (Воин) получил {damage} урона. " +
                $"Текущее здоровье: {HP:F}");
        }
        public void Attack(Character target)
        {
            double damage = meleeDamage; 
            Console.WriteLine($"{name} (Воин) атакует {target.name} на {damage:F} урона.");
            target.TakeDamage(damage);
        }
        new public void show()
        {
           base.show();
            Console.WriteLine($"Броня персонажа: {armor:F2}" +"\n" +
                              $"Урон оружием: {meleeDamage:F2}" + "\n");
        }
    }
}
