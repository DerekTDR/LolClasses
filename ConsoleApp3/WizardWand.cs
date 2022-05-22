using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolClasses
{
    public class WizardWand : Item
    {
        public WizardWand()
        {
            name = "Wizard Wand";
            price = 500;
            AddStat(Stat.AP, 30);
            AddStat(Stat.AD, 10);
        }
    }
}