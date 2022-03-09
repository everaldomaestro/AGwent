using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Factions.Scoiatael
{
    public sealed class ElvenSkirmisher : UnitCard
    {
        public ElvenSkirmisher()
        {
            Name = "Elven Skirmisher";
            Description = "No matter what you may have heard, elves don't take human scalps. Too much lice.";
            StrengthValueOriginal = 2;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.RANGED };
            Hero = false;
            Category = Category.FACTION;
            Faction = new Factories.Factions.Scoiatael();
            Ability = new Abilities.Muster();
            Count = 3;
        }
    }
}
