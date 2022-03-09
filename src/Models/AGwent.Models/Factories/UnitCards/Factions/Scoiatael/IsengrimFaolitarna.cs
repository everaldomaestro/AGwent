using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Factions.Scoiatael
{
    public sealed class IsengrimFaolitarna : UnitCard
    {
        public IsengrimFaolitarna()
        {
            Name = "Isengrim Faolitarna";
            Description = "It dawns on them once they notice my scar: a realization of imminent death.";
            StrengthValueOriginal = 10;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.CLOSE };
            Hero = true;
            Category = Category.FACTION;
            Faction = new Factories.Factions.Scoiatael();
            Ability = new Abilities.MoraleBoost();
        }
    }
}
