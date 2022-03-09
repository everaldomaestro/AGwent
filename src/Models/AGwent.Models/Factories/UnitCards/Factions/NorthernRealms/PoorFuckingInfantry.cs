using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Factions.NorthernRealms
{
    public sealed class PoorFuckingInfantry : UnitCard
    {
        public PoorFuckingInfantry()
        {
            Name = "Poor Fucking Infantry";
            Description = "I's a war veteran! ...spare me a crown?";
            StrengthValueOriginal = 1;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.CLOSE };
            Hero = false;
            Category = Category.FACTION;
            Faction = new Factories.Factions.NorthernRealms();
            Ability = new Abilities.TightBond();
            Copy = 2;
        }
    }
}
