using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace ITMO.CS_Paractice.LabFinal
{
    public abstract class Character
    {
        public string name;
        public double HP;
        public double MaxHP;
        public double level;
        
        public Character(string name,double HP, double level, double MaxHP)
        {
            this.name = name;
            this.HP = HP*(level*1.15);
            this.level = level;
            this.MaxHP = MaxHP*(level*1.15);
        }
        public abstract void TakeDamage(double damage);

        protected void Die()
        {
            Console.WriteLine($"{name} погибает.");
        }

        public void show()
        {
            Console.WriteLine($"Имя Персонажа: {name}" + "\n" +
                              $"Здоровье: {HP:F2}/{MaxHP:F}" + "\n" +
                              $"Уровень персонажа: {level}");
        }
    }
}
