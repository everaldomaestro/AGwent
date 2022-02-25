using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Neutrals
{
    public sealed class MysteriousElf : UnitCard
    {
        public MysteriousElf()
        {
            Name = "MysteriousElf";
            Description = "You humans have... unusual tastes.";
            StrengthValueOriginal = 0;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.CLOSE };
            Hero = true;
            Category = Category.NEUTRAL;
            Ability = new Abilities.Spy();
        }
    }
}
