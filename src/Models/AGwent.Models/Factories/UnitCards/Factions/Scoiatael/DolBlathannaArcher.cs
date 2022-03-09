using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Factions.Scoiatael
{
    public sealed class DolBlathannaArcher : UnitCard
    {
        public DolBlathannaArcher()
        {
            Name = "Dol Blathanna Archer";
            Description = "Take another step, dh'oine. You'd look better with an arrow between your eyes.";
            StrengthValueOriginal = 4;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.RANGED };
            Hero = false;
            Category = Category.FACTION;
            Faction = new Factories.Factions.Scoiatael();
        }
    }
}
