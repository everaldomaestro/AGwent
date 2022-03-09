using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Factions.NorthernRealms
{
    public sealed class Trebuchet : UnitCard
    {
        public Trebuchet()
        {
            Name = "Trebuchet";
            Description = "Castle won't batter itself down, now will it? Get them trebuchets rollin'!";
            StrengthValueOriginal = 6;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.SIEGE };
            Hero = false;
            Category = Category.FACTION;
            Faction = new Factories.Factions.NorthernRealms();
            Count = 2;
        }
    }
}
