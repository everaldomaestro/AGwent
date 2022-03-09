using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Factions.NorthernRealms
{
    public sealed class NausicaaCavalryRider : UnitCard
    {
        public NausicaaCavalryRider()
        {
            Name = "Nausicaa Cavalry Rider";
            Description = "The Emperor will teach the North discipline";
            StrengthValueOriginal = 2;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.CLOSE };
            Hero = false;
            Category = Category.FACTION;
            Faction = new Factories.Factions.Nilfgaard();
            Ability = new Abilities.TightBond();
            Copy = 2;
        }
    }
}
