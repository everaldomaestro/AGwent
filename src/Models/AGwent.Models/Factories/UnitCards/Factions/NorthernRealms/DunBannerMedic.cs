using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Factions.NorthernRealms
{
    public sealed class DunBannerMedic : UnitCard
    {
        public DunBannerMedic()
        {
            Name = "Dun Banner Medic";
            Description = "Stitch red to red, white to white, and everything will be all right.";
            StrengthValueOriginal = 5;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.SIEGE };
            Hero = false;
            Category = Category.FACTION;
            Ability = new Abilities.Medic();
            Faction = new Factories.Factions.NorthernRealms();
        }
    }
}
