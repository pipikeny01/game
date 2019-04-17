using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gmae
{
    public class EquipmentFactory
    {
        public BaseWeapon Get屠龍刀()
        {
            return new 屠龍刀();
        }

        public BaseWeapon Get倚天劍()
        {
            return new 倚天劍();
        }

        public BaseArmor Get布甲()
        {
            return new 布甲();
        }
    }


}
