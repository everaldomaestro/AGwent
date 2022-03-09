using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Factions.Scoiatael
{
    public sealed class HavekarHealer : UnitCard
    {
        public HavekarHealer()
        {
            Name = "Havekar Healer";
            Description = "Sure, I'll patch you up. Gonna cost you though.";
            StrengthValueOriginal = 0;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.RANGED };
            Hero = false;
            Category = Category.FACTION;
            Faction = new Factories.Factions.Scoiatael();
            Ability = new Abilities.Medic();
            Count = 3;
        }
    }
}
