using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character
{
    class Character
    {
        public string CharacterName;
        // Name
        //{
        // Console.ReadLine(string.Parse) or string.Parse(Console.ReadLine);
        // Console.WriteLine("Please enter your name)
        //}

        public string Height;
        // Height
        //{
        // int.Parse(Console.ReadLine());
        // result = '0';
        // Console.WriteLine("Please enter your height in inches(Hint: 12 inches = 1ft)":
        // 
        //}

        public string EyeColor;
        // Red, Blue, Green, Yellow, Purple, Orange, Light Green, Light Blue, Hazel
        // Eye Color

        public string SkinColor;
        // string.Parse(Console.ReadLine)
        // White, Tan, Brown/Black (African American) 
        // Skin Color

        public string HairColor;
        // Blonde, Brunette, Black, Red Head/Ginger, 
        // Hair Color

        public Character(string CharacterName, string Height, string EyeColor, string SkinColor, string HairColor)
        {
            this.CharacterName = CharacterName;
            this.Height = Height;
            this.EyeColor = EyeColor;
            this.SkinColor = SkinColor;
            this.HairColor = HairColor;

        }
    }
}
