using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Factions.Scoiatael
{
    public sealed class Saesenthessis : UnitCard
    {
        public Saesenthessis()
        {
            Name = "Saesenthessis";
            Description = "Beautiful, pure, fierce - the perfect icon for a rebellion.";
            StrengthValueOriginal = 10;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] {  Row.RANGED };
            Hero = true;
            Category = Category.FACTION;
            Faction = new Factories.Factions.Scoiatael();
        }
    }
}
