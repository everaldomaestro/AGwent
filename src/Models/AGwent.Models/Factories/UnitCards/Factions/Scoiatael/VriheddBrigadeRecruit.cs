using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Factions.Scoiatael
{
    public sealed class VriheddBrigadeRecruit : UnitCard
    {
        public VriheddBrigadeRecruit()
        {
            Name = "Vrihedd Brigade Recruit";
            Description = "Hatred burns brighter than any fire, and cuts deeper than any blade.";
            StrengthValueOriginal = 4;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.RANGED };
            Hero = false;
            Category = Category.FACTION;
            Faction = new Factories.Factions.Scoiatael();
        }
    }
}
