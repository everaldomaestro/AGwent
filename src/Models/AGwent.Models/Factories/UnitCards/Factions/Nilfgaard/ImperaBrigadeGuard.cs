using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Factions.NorthernRealms
{
    public sealed class ImperaBrigadeGuard : UnitCard
    {
        public ImperaBrigadeGuard()
        {
            Name = "Impera Brigade Guard";
            Description = "The Impera Brigade never surrenders. Ever.";
            StrengthValueOriginal = 3;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.CLOSE };
            Hero = false;
            Category = Category.FACTION;
            Faction = new Factories.Factions.Nilfgaard();
            Ability = new Abilities.TightBond();
            Copy = 3;
        }
    }
}
