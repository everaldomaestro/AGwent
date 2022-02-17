using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Factions.NorthernRealms
{
    public class Trebuchet : UnitCard
    {
        public Trebuchet()
        {
            Name = "Trebuchet";
            Description = "";
            StrengthValueOriginal = 6;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.SIEGE };
            Hero = false;
            Category = Category.FACTION;
        }
    }
}
