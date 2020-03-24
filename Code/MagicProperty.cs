using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemShop
{
    public class MagicProperty
    {
        public string Name { get; set; }
        public string BuffType { get; set; }
        public int BuffValue { get; set; }

        public MagicProperty(string name, string bufftype)
        {
            Name = name;
            BuffType = bufftype;
        }

        /// <summary>
        /// Get a easy readable string with the details of the property.
        /// </summary>
        /// <returns></returns>
        public string GetDescription()
        {
            switch (this.BuffType)
            {
                case ("Percentage"):
                    return ("*    " + Name + " Increased by " + BuffValue + "%");
                case ("Value"):
                    return ("*    " + Name + " Increased by " + BuffValue);
            }
            return (null);

        }

    }
}
