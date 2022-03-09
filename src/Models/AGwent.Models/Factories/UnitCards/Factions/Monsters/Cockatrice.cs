#nullable disable
using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Factions.Monsters
{
    public sealed class Cockatrice : UnitCard
    {
        public Cockatrice()
        {
            Name = "Cockatrice";
            Description = "Born of an egg laid by a cockerel... if you believe such peasant drivel.";
            StrengthValueOriginal = 2;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.RANGED };
            Hero = false;
            Category = Category.FACTION;
            Faction = new Factories.Factions.Monsters();
        }
    }
}
