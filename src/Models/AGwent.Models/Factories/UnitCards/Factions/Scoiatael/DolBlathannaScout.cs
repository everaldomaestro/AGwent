using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Factions.Scoiatael
{
    public sealed class DolBlathannaScout : UnitCard
    {
        public DolBlathannaScout()
        {
            Name = "Dol Blathanna Scout";
            Description = "They track like hounds, run like deer and kill like cold-hearted bastards.";
            StrengthValueOriginal = 6;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.CLOSE, Row.RANGED };
            Hero = false;
            Category = Category.FACTION;
            Faction = new Factories.Factions.Scoiatael();
            Ability = new Abilities.Agile();
            Count = 3;
        }
    }
}
