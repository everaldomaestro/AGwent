using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Factions.NorthernRealms
{
    public sealed class BlackInfantryArcher : UnitCard
    {
        public BlackInfantryArcher()
        {
            Name = "Black Infantry Archer";
            Description = "I aim for the knee. Always.";
            StrengthValueOriginal = 10;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.RANGED };
            Hero = false;
            Category = Category.FACTION;
            Faction = new Factories.Factions.Nilfgaard();
            Count = 2;
        }
    }
}
