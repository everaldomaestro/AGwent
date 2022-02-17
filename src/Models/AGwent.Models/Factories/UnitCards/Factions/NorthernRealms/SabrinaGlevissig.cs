using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Factions.NorthernRealms
{
    public class SabrinaGlevissig : UnitCard
    {
        public SabrinaGlevissig()
        {
            Name = "Sabrina Glevissig";
            Description = "The Daughter of the Kaedweni Wilderness.";
            StrengthValueOriginal = 4;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.RANGED };
            Hero = false;
            Category = Category.FACTION;
        }
    }
}
