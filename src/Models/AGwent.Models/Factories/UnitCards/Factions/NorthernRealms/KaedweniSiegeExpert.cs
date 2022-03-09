using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Factions.NorthernRealms
{
    public sealed class KaedweniSiegeExpert : UnitCard
    {
        public KaedweniSiegeExpert()
        {
            Name = "Kaedweni Siege Expert";
            Description = "You gotta recalibrate the arm by five degrees. Do what by the what now?";
            StrengthValueOriginal = 1;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.SIEGE };
            Hero = false;
            Category = Category.FACTION;
            Ability = new Abilities.MoraleBoost();
            Faction = new Factories.Factions.NorthernRealms();
            Count = 3;
        }
    }
}
