using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Neutrals
{
    public sealed class GeraltOfRivia : UnitCard
    {
        public GeraltOfRivia()
        {
            Name = "Geralt of Rivia";
            Description = "If that's what it takes to save the world, it's better to let that world die.";
            StrengthValueOriginal = 15;
            Ranges = new Row[] { Row.CLOSE };
            Hero = true;
            Category = Category.NEUTRAL;
        }
    }
}
