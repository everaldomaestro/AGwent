using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Factions.NorthernRealms
{
    public class YarpenZigrin : UnitCard
    {
        public YarpenZigrin()
        {
            Name = "Yarpen Zigrin";
            Description = "The world belongs to whoever's best at crackin' skulls and impregnatin' lasses.";
            StrengthValueOriginal = 2;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.CLOSE };
            Hero = false;
            Category = Category.FACTION;
        }
    }
}
