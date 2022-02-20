using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Neutrals
{
    public sealed class Vesemir : UnitCard
    {
        public Vesemir()
        {
            Name = "Vesemir";
            Description = "";
            StrengthValueOriginal = 6;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.CLOSE };
            Hero = false;
            Category = Category.NEUTRAL;
        }
    }
}
