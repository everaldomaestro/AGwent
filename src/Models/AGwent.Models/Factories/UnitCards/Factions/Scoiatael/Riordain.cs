using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Factions.Scoiatael
{
    public sealed class Riordain : UnitCard
    {
        public Riordain()
        {
            Name = "Riordain";
            Description = "Stare into their eyes, feast on their terror. Then go in for the kill.";
            StrengthValueOriginal = 1;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.RANGED };
            Hero = false;
            Category = Category.FACTION;
            Faction = new Factories.Factions.Scoiatael();
        }
    }
}
