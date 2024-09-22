using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ITMO.CS_Paractice.LabFinal
{
    internal class Mage : Character, ISpellCast
    {
        public double spellDamage;
        private double vulnerability = 1.25;

        public Mage (double spellDamage, string name,
            double HP, double level, double MaxHP) : base(name, HP, level, MaxHP)
        {
            this.spellDamage = spellDamage*(level*1.25);
        }

        public override void TakeDamage(double damage)
        {
            HP -= damage*vulnerability;
            if (HP <= 0)
            {
                Die();
                HP = 0;
            }
            else
                Console.WriteLine($"{name} (Маг) получил {damage} урона. " +
                $"Текущее здоровье: {HP:F}");
        }

        public void CastSpell(Character target)
        {
            double damage = spellDamage*1.35; // Урон от заклинания Arrow
            Console.WriteLine($"{name}(Маг) использует заклинание Arrow на {target.name}(Противник)");
            target.TakeDamage(damage);
        }

        new public void show()
        {
            base.show();
            Console.WriteLine($"Сила заклинаний: {spellDamage:F2}" +"\n" +
                              $"Уязвимость перед атаками: {vulnerability*100:F2}%" + "\n");
        }
    }
}
