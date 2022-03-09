using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Factions.NorthernRealms
{
    public sealed class BlueStripesCommando : UnitCard
    {
        public BlueStripesCommando()
        {
            Name = "Blue Stripes Commando";
            Description = "I'd do anything for Temeria. Mostly, though, I kill for her.";
            StrengthValueOriginal = 4;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.CLOSE };
            Hero = false;
            Category = Category.FACTION;
            Faction = new Factories.Factions.NorthernRealms();
            Ability = new Abilities.TightBond();
            Copy = 2;
        }
    }
}
