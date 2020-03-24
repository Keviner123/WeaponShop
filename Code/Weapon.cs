using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ItemShop
{
    public abstract class Weapon
    {
        public string Name { get; set; }
        public int Rarity { get; set; }
        public int AmountOfProperties { get; set; }
        public int DamageMin { get; set; }
        public int DamageMax { get; set; }
        public double AttacksPerSecond { get; set; }
        public List<MagicProperty> MagicProperties { get; set; }

        Random r = new Random();

        public Weapon(string name)
        {
            Name = name;
            SetRandomRarity();
            SetAmountOfProperties();
            SetRandomBasicDamage();
            SetRandomAttacksPerSecond();
            MagicProperties = new List<MagicProperty>();
        }

        /// <summary>
        /// Set a random rarity to the weapon
        /// </summary>
        public void SetRandomRarity()
        {
            this.Rarity = r.Next(0, 4);
            // I'm adding a tiny delay since the pseudorandom function 
            // uses CPU cycle to generate our number
            Thread.Sleep(5); 
        }

        /// <summary>
        /// Generate a random basic dammage
        /// </summary>
        public void SetRandomBasicDamage()
        {
            this.DamageMin = r.Next(0, 300);
            this.DamageMax = r.Next(DamageMin, 300);
        }

        /// <summary>
        /// Generate a random APS
        /// </summary>
        public void SetRandomAttacksPerSecond()
        {
            this.AttacksPerSecond = Math.Round(r.NextDouble() * (2.0 - 1.0) + 2.0, 2);
        }

        /// <summary>
        /// Set the amount of properties the weapon should have
        /// </summary>
        public void SetAmountOfProperties() {
            int amountOfProperties = 0;

            switch (this.Rarity)
            {
                case (0):
                    amountOfProperties = 0;
                    break;
                case (1):
                    amountOfProperties = r.Next(1, 3);
                    break;
                case (2):
                    amountOfProperties = r.Next(4, 6);
                    break;
                case (3):
                    amountOfProperties = 6;
                    break;
            }
            AmountOfProperties = amountOfProperties;
        }
    }
}
