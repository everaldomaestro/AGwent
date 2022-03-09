using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Factions.NorthernRealms
{
    public sealed class VattierDeRideaux : UnitCard
    {
        public VattierDeRideaux()
        {
            Name = "Vattier de Rideaux";
            Description = "There's never been a problem a well-planned assassination couldn't solve";
            StrengthValueOriginal = 4;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.CLOSE };
            Hero = false;
            Category = Category.FACTION;
            Faction = new Factories.Factions.Nilfgaard();
            Ability = new Abilities.Spy();
        }
    }
}
