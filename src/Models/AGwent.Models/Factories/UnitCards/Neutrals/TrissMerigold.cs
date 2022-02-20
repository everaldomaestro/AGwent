using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Neutrals
{
    public sealed class TrissMerigold : UnitCard
    {
        public TrissMerigold()
        {
            Name = "Triss Merigold";
            Description = "";
            StrengthValueOriginal = 7;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.CLOSE };
            Hero = true;
            Category = Category.NEUTRAL;
        }
    }
}
