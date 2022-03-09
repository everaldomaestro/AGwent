using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Factions.Scoiatael
{
    public sealed class BarclayEls : UnitCard
    {
        public BarclayEls()
        {
            Name = "Barclay Els";
            Description = "Our mead smells like piss, do it? Easy to fix - I'll break your fuckin' nose.";
            StrengthValueOriginal = 6;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.CLOSE, Row.RANGED };
            Hero = false;
            Category = Category.FACTION;
            Faction = new Factories.Factions.Scoiatael();
            Ability = new Abilities.Agile();
        }
    }
}
