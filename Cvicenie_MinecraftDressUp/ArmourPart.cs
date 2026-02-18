using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Cvicenie_MinecraftDressUp
{
    public class ArmourPart
    {
        public string DisplayName { get; set; }
        public int ArmourPower { get; set; }
        public EArmourType ArmourType { get; set; }
        public EArmourpartName PartName { get; set; }
        public int XLeft { get; set; }
        public int YTop { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public ArmourPart(string displayName, int armourPower, EArmourType armourType, EArmourpartName partName, int XLeft, int YTop, int width, int height)
        {
            DisplayName = displayName;
            ArmourPower = armourPower;
            ArmourType = armourType;
            PartName = partName;
            this.XLeft = XLeft;
            this.YTop = YTop;
            Width = width;
            Height = height;
        }

        public override string ToString()
        {
            return DisplayName;
        }
    }

}
