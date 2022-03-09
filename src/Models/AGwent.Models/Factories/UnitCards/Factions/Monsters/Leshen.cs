#nullable disable
using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Factions.Monsters
{
    public sealed class Leshen : UnitCard
    {
        public Leshen()
        {
            Name = "Leshen";
            Description = "We never hunt in these woods. Not even if it means the whole village starves.";
            StrengthValueOriginal = 10;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.RANGED };
            Hero = true;
            Category = Category.FACTION;
            Faction = new Factories.Factions.Monsters();
        }
    }
}
