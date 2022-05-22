using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolClasses
{
    internal class Annie : Champion
    {
        public Annie()
        {
            name = "Annie";
            hp = 524;
            ad = 0;
            ap = 50;
            Console.WriteLine("Konstruktor klasy Annie");
        }
        public void Q()
        {
            float price = 80;
            float cooldown = 4;
            float dmg = 220 + (0.75F * ap);
        }
        public void W()
        {
            float price = 110;
            float cooldown = 8;
            float dmg = 250 + (0.85F * ap);
        }
        public void E()
        {
            float price = 40;
            float cooldown = 10;
            float def = 240 + (0.4F * ap);
            float dmg = 60 + (0.2F * ap);
        }
        public void R()
        {
            float price = 100;
            float cooldown = 80;
            float dmg = 400 + (0.75F * ap);
        }
    }
}
