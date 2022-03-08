using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Factions.NorthernRealms
{
    public sealed class Thaler : UnitCard
    {
        public Thaler()
        {
            Name = "Thaler";
            Description = "Fuck off! We aren't all ploughin' philanderers. Some of us have depth...";
            StrengthValueOriginal = 1;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.SIEGE };
            Hero = false;
            Category = Category.FACTION;
            Ability = new Abilities.Spy();
            Faction = new Factories.Factions.NorthernRealms();
        }
    }
}
