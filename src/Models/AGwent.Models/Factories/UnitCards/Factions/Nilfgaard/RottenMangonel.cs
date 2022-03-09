using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Factions.NorthernRealms
{
    public sealed class RottenMangonel : UnitCard
    {
        public RottenMangonel()
        {
            Name = "Rotten Mangonel";
            Description = "The rotten smell brings back childhood memories.";
            StrengthValueOriginal = 3;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.SIEGE };
            Hero = false;
            Category = Category.FACTION;
            Faction = new Factories.Factions.Nilfgaard();
        }
    }
}
