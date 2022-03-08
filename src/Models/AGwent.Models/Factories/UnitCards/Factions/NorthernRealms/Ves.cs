using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Factions.NorthernRealms
{
    public sealed class Ves : UnitCard
    {
        public Ves()
        {
            Name = "Ves";
            Description = "Better to live one day as a king than a whole life as a beggar.";
            StrengthValueOriginal = 5;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.CLOSE };
            Hero = false;
            Category = Category.FACTION;
            Faction = new Factories.Factions.NorthernRealms();
        }
    }
}
