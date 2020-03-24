using ItemShop.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemShop
{
    public class WeaponFactory
    {

        /// <summary>
        /// Insert a weapon with an appropriate subclass based on the argument
        /// </summary>
        public Weapon CreateWeapon(string WeaponType)
        {
            switch (WeaponType)
            {
                case ("Axe"):
                    return new Axe("Axe");
                case ("Ceremonial_Knives"):
                    return new Ceremonial_Knives("Ceremonial_Knives");
                case ("Dagger"):
                    return new Dagger("Dagger");
                case ("Fist_Weapons"):
                    return new Fist_Weapons("Fist_Weapons");
                case ("Flails"):
                    return new Flails("Flails");
                case ("Maces"):
                    return new Maces("Maces");
                case ("Mighty_Weapons"):
                    return new Mighty_Weapons("Mighty_Weapons");
                case ("Scythes"):
                    return new Scythes("Scythes");
                case ("Spears"):
                    return new Spears("Spears");
                case ("Sword"):
                    return new Sword("Sword");
            }

            return (null);
        }
    }
}
