using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Factions.NorthernRealms
{
    public class Dethmold : UnitCard
    {
        public Dethmold()
        {
            Name = "Dethmold";
            Description = "I once made a prisoner vomit his own entrails... Ah, good times...";
            StrengthValueOriginal = 6;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.RANGED };
            Hero = false;
            Category = Category.FACTION;
        }
    }
}
