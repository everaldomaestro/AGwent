using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Factions.NorthernRealms
{
    public sealed class Catapult : UnitCard
    {
        public Catapult()
        {
            Name = "Catapult";
            Description = "The gods help those who have better catapults.";
            StrengthValueOriginal = 8;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.SIEGE };
            Hero = false;
            Category = Category.FACTION;
            Ability = new Abilities.TightBond();
            Faction = new Factories.Factions.NorthernRealms();
            Copy = 1;
        }
    }
}
