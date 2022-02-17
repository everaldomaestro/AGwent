using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Factions.NorthernRealms
{
    public class RedanianFootSoldier : UnitCard
    {
        public RedanianFootSoldier()
        {
            Name = "Redanian Foot Soldier";
            Description = "";
            StrengthValueOriginal = 1;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.CLOSE };
            Hero = false;
            Category = Category.FACTION;
        }
    }
}
