using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Factions.NorthernRealms
{
    public sealed class Puttkammer : UnitCard
    {
        public Puttkammer()
        {
            Name = "Puttkammer";
            Description = "Learned a lot at Braibant Military Academy. How to scrub potatoes, for instance.";
            StrengthValueOriginal = 3;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.RANGED };
            Hero = false;
            Category = Category.FACTION;
            Faction = new Factories.Factions.Nilfgaard();
        }
    }
}
