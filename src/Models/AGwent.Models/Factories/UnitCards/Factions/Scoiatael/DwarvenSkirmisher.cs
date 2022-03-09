using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Factions.Scoiatael
{
    public sealed class DwarvenSkirmisher : UnitCard
    {
        public DwarvenSkirmisher()
        {
            Name = "Dwarven Skirmisher";
            Description = "Worked a pickaxe all me life. Battleaxe won't be any trouble.";
            StrengthValueOriginal = 3;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.CLOSE };
            Hero = false;
            Category = Category.FACTION;
            Faction = new Factories.Factions.Scoiatael();
            Ability = new Abilities.Muster();
            Count = 3;
        }
    }
}
