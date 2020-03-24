using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ItemShop
{
    public class WeaponShop
    {
        public List<MagicProperty> MagicProperties { get; set; }
        public List<Weapon> Weapons { get; set; }

        public WeaponShop()
        {
            this.MagicProperties = new List<MagicProperty>();
            this.Weapons = new List<Weapon>();
            SetMagicProperties();
        }

        /// <summary>
        /// Set the magic properties our shop is able to asssign to weapons.
        /// </summary>
        public void SetMagicProperties()
        {
            MagicProperties.Add(new MagicProperty("Damage", "Percentage"));
            MagicProperties.Add(new MagicProperty("Chance to Block", "Percentage"));
            MagicProperties.Add(new MagicProperty("Movement Speed", "Percentage"));
            MagicProperties.Add(new MagicProperty("Attack Speed", "Percentage"));
            MagicProperties.Add(new MagicProperty("Critical Hit Damage", "Percentage"));
            MagicProperties.Add(new MagicProperty("Critical Hit Chance", "Percentage"));
            MagicProperties.Add(new MagicProperty("Reduces Cooldown of all Skills", "Percentage"));
            MagicProperties.Add(new MagicProperty("Reduces all Resource Costs", "Percentage"));
            MagicProperties.Add(new MagicProperty("Chance to Block increased", "Percentage"));

            MagicProperties.Add(new MagicProperty("Armor", "Value"));
            MagicProperties.Add(new MagicProperty("Life", "Value"));
            MagicProperties.Add(new MagicProperty("Vitality", "Value"));
        }

        /// <summary>
        /// Get a random magic property with a buff value.
        /// </summary>
        public MagicProperty GetRandomMagicProperty()
        {
            var r = new Random();
            Thread.Sleep(10);
            int index = r.Next(this.MagicProperties.Count);

            //Roll the buff value
            switch (MagicProperties[index].BuffType)
            {
                case ("Percentage"):
                    MagicProperties[index].BuffValue = r.Next(100);
                    break;

                case ("Value"):
                    MagicProperties[index].BuffValue = r.Next(300);
                    break;
            }

            return (MagicProperties[index]);
        }

        /// <summary>
        /// Set a magic property to a weapon in the shop
        /// </summary>
        public void SetWeaponsMagicProperties()
        {
            for (int i = 0; i < Weapons.Count; i++)
            {
                for (int p = 0; p < Weapons[i].AmountOfProperties; p++)
                {
                    Weapons[i].MagicProperties.Add(GetRandomMagicProperty());
                }
            }
        }
    }
}
