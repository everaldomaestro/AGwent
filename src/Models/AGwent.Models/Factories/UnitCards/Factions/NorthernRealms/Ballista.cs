using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Factions.NorthernRealms
{
    public sealed class Ballista : UnitCard
    {
        public Ballista()
        {
            Name = "Ballista";
            Description = "Usually we give 'em female names. 'Like Jenny?' More like Bertha.";
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
