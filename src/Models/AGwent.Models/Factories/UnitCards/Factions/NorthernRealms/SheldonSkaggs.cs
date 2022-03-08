using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Factions.NorthernRealms
{
    public sealed class SheldonSkaggs : UnitCard
    {
        public SheldonSkaggs()
        {
            Name = "Sheldon Skaggs";
            Description = "I was there, on the front lines! Right where the fightin' was the thickest!";
            StrengthValueOriginal = 4;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.RANGED };
            Hero = false;
            Category = Category.FACTION;
            Faction = new Factories.Factions.NorthernRealms();
        }
    }
}
