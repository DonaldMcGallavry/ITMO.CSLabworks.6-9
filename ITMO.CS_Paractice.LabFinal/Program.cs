namespace ITMO.CS_Paractice.LabFinal
{
    internal class Program
    {
        static void Main()
        {
            Warrior w1 = new Warrior(2, 5, "Arthas", 100, 4, 100);
            Mage m1 = new Mage(10, "Merlin", 85, 4, 85);
            Healer h1 = new Healer(8, "Anna", 100, 6, 100);
            Enemy e1 = new Enemy(4, 10, "Mairon", 200, 5, 200);

            //e1.show();
            //m1.show();
            //e1.show();
            //h1.show();
            //e1.Attack(h1);
            m1.CastSpell(e1);
            h1.CastSpell(w1);
            w1.Attack(e1);
        }
    }
}
