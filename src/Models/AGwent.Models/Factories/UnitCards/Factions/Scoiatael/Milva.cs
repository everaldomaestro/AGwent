using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Factions.Scoiatael
{
    public sealed class Milva : UnitCard
    {
        public Milva()
        {
            Name = "Milva";
            Description = "With each arrow I loose, I think of my da. He'd be proud. I think.";
            StrengthValueOriginal = 10;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] {  Row.RANGED };
            Hero = false;
            Category = Category.FACTION;
            Faction = new Factories.Factions.Scoiatael();
            Ability = new Abilities.MoraleBoost();
        }
    }
}
