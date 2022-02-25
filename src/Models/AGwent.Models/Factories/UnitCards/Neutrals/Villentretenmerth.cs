using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Neutrals
{
    public sealed class Villentretenmerth : UnitCard
    {
        public Villentretenmerth()
        {
            Name = "Villentretenmerth";
            Description = "Also calls himself Borkh Three Jackdaws... he's not the best at names.";
            StrengthValueOriginal = 7;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.CLOSE };
            Hero = false;
            Category = Category.NEUTRAL;
            Ability = new Abilities.Scorch(Type);
        }
    }
}
