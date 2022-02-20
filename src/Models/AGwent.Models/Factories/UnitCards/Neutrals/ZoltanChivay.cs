using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Neutrals
{
    public sealed class ZoltanChivay : UnitCard
    {
        public ZoltanChivay()
        {
            Name = "Zoltan Chivay";
            Description = "";
            StrengthValueOriginal = 5;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.CLOSE };
            Hero = false;
            Category = Category.NEUTRAL;
        }
    }
}
