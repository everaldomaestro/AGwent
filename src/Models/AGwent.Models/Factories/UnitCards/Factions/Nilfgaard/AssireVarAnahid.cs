using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Factions.NorthernRealms
{
    public sealed class AssireVarAnahid : UnitCard
    {
        public AssireVarAnahid()
        {
            Name = "Assire var Anahid";
            Description = "Nilfgaardian mages do have a choice: servile submission, or the gallows";
            StrengthValueOriginal = 6;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.RANGED };
            Hero = false;
            Category = Category.FACTION;
            Faction = new Factories.Factions.Nilfgaard();
        }
    }
}
