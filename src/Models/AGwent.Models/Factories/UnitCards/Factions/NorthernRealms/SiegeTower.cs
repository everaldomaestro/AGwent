using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Factions.NorthernRealms
{
    public sealed class SiegeTower : UnitCard
    {
        public SiegeTower()
        {
            Name = "Siege Tower";
            Description = "I love the clamor of siege towers in the morning. Sounds like victory.";
            StrengthValueOriginal = 6;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.SIEGE };
            Hero = false;
            Category = Category.FACTION;
            Faction = new Factories.Factions.NorthernRealms();
        }
    }
}
