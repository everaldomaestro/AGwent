using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Factions.Scoiatael
{
    public sealed class IdaEmeanAepSivney : UnitCard
    {
        public IdaEmeanAepSivney()
        {
            Name = "Ida Emean aep Sivney";
            Description = "I am a sage. My power lies in possessing knowledge. Not sharing it.";
            StrengthValueOriginal = 6;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.RANGED };
            Hero = false;
            Category = Category.FACTION;
            Faction = new Factories.Factions.Scoiatael();
        }
    }
}
