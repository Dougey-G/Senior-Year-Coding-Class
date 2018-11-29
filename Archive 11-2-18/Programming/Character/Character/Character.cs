using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character
{
    class Character
    {
        public string Name;
        public string Height;
        public string EyeColor;
        public string SkinColor;
        public string HairColor;
        public string ShirtColor;
        
        public Character(string Name, string Height, string EyeColor, string SkinColor, string HairColor, string ShirtColor)
        {
            this.Name = Name;
            this.Height = Height;
            this.EyeColor = EyeColor;
            this.SkinColor = SkinColor;
            this.HairColor = HairColor;
            this.ShirtColor = ShirtColor;
        }
    }
}
