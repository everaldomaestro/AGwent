using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Neutrals
{
    public class GeraltOfRivia : UnitCard
    {
        public GeraltOfRivia()
        {
            Name = "Geralt of Rivia";
            Description = "";
            StrengthValueOriginal = 15;
            Ranges = new Row[] { Row.CLOSE };
            Hero = true;
            Category = Category.NEUTRAL;
        }
    }
}
