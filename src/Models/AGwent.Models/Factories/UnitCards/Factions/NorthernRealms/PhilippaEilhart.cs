using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Factions.NorthernRealms
{
    public sealed class PhilippaEilhart : UnitCard
    {
        public PhilippaEilhart()
        {
            Name = "Philippa Eilhart";
            Description = "Soon the power of kings will wither, and the Lodge shall seize its rightful place.";
            StrengthValueOriginal = 10;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.RANGED };
            Hero = true;
            Category = Category.FACTION;
            Faction = new Factories.Factions.NorthernRealms();
        }
    }
}
