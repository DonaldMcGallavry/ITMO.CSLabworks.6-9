using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ITMO.CS_Paractice.LabFinal
{
    internal class Healer: Character, ISpellCast
    {
        public double healPower;


        public Healer (double healPower, string name,
            double HP, double level, double MaxHP) : base(name, HP, level, MaxHP)
        {
            this.healPower = healPower*(level*1.15);
        }

        public override void TakeDamage(double damage)
        {
            HP -= damage;
            if (HP <= 0)
            {
                Die();
                HP = 0;
            }
            else
                Console.WriteLine($"{name} (Целитель) получил {damage} урона. " +
                $"Текущее здоровье: {HP:F}");
        }

        public void CastSpell(Character target)
        {
            if (target.HP >= target.MaxHP)
            {
                Console.WriteLine($"{target.name} уже полностью здоров.");
                return; // Прекращаем выполнение, если здоровье уже максимальное
            }
            
            target.HP += healPower;
            if(target.HP>target.MaxHP)
            {
                target.HP = target.MaxHP;
            }
            Console.WriteLine($"{name}(Целитель) исцеляет {target.name} на {healPower:F} ед. здоровья. " +
                $"Текущее здоровье цели: {target.HP:F}");
        }
        new public void show()
        {
            base.show();
            Console.WriteLine($"Сила исцеления: {healPower :F2}" + "\n");
        }
    }
}
