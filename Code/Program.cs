using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ItemShop
{
    class Program
    {
        static void Main(string[] args)
        {

            WeaponShop CurrentWeaponShop = new WeaponShop();

            //Add two of each Weapon Type to our shop
            for (int i = 0; i < 2; i++)
            {
                CurrentWeaponShop.Weapons.Add(new WeaponFactory().CreateWeapon("Axe"));
                CurrentWeaponShop.Weapons.Add(new WeaponFactory().CreateWeapon("Ceremonial_Knives"));
                CurrentWeaponShop.Weapons.Add(new WeaponFactory().CreateWeapon("Dagger"));
                CurrentWeaponShop.Weapons.Add(new WeaponFactory().CreateWeapon("Fist_Weapons"));
                CurrentWeaponShop.Weapons.Add(new WeaponFactory().CreateWeapon("Flails"));
                CurrentWeaponShop.Weapons.Add(new WeaponFactory().CreateWeapon("Maces"));
                CurrentWeaponShop.Weapons.Add(new WeaponFactory().CreateWeapon("Mighty_Weapons"));
                CurrentWeaponShop.Weapons.Add(new WeaponFactory().CreateWeapon("Scythes"));
                CurrentWeaponShop.Weapons.Add(new WeaponFactory().CreateWeapon("Spears"));
                CurrentWeaponShop.Weapons.Add(new WeaponFactory().CreateWeapon("Sword"));
            }

            //Set the magic properties to our weapons
            CurrentWeaponShop.SetWeaponsMagicProperties();

            //Display the shop items
            foreach (var CurrentWeapon in CurrentWeaponShop.Weapons)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(CurrentWeapon.Name);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Basic Damage: "+CurrentWeapon.DamageMin+"-"+CurrentWeapon.DamageMax);
                Console.WriteLine("Attacks per Second:" + CurrentWeapon.AttacksPerSecond);
                for (int i = 0; i < CurrentWeapon.MagicProperties.Count(); i++)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(CurrentWeapon.MagicProperties[i].GetDescription());
                }

            }



            Console.ReadLine();
        }
    }
}
