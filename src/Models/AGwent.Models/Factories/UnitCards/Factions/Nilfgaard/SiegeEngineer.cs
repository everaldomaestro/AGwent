using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Factions.NorthernRealms
{
    public sealed class SiegeEngineer : UnitCard
    {
        public SiegeEngineer()
        {
            Name = "Siege Engineer";
            Description = "Wielded correctly, a protractor can be a deadly weapon.";
            StrengthValueOriginal = 6;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.SIEGE };
            Hero = false;
            Category = Category.FACTION;
            Faction = new Factories.Factions.Nilfgaard();
        }
    }
}
