using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Neutrals
{
    public sealed class Vesemir : UnitCard
    {
        public Vesemir()
        {
            Name = "Vesemir";
            Description = "If you're to be hanged, ask for water. Anything can happen before they fetch it.";
            StrengthValueOriginal = 6;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.CLOSE };
            Hero = false;
            Category = Category.NEUTRAL;
        }
    }
}
