using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Factions.NorthernRealms
{
    public sealed class CrinfridReaversDragonHunter : UnitCard
    {
        public CrinfridReaversDragonHunter()
        {
            Name = "Crinfrid Reavers Dragon Hunter";
            Description = "Haven't had much luck with monsters of late, so we enlisted.";
            StrengthValueOriginal = 5;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.RANGED };
            Hero = false;
            Category = Category.FACTION;
            Faction = new Factories.Factions.NorthernRealms();
            Ability = new Abilities.TightBond();
            Copy = 2;
        }
    }
}
