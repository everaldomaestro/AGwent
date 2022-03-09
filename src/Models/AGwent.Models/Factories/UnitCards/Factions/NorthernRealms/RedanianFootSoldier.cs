using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Factions.NorthernRealms
{
    public sealed class RedanianFootSoldier : UnitCard
    {
        public RedanianFootSoldier()
        {
            Name = "Redanian Foot Soldier";
            Description = "I've bled for Redania! I've killed for Redania... Dammit, I've even raped for Redania!";
            StrengthValueOriginal = 1;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.CLOSE };
            Hero = false;
            Category = Category.FACTION;
            Faction = new Factories.Factions.NorthernRealms();
            Count = 2;
        }
    }
}
