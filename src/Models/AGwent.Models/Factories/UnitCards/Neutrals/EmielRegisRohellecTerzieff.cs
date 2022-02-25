using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Neutrals
{
    public sealed class EmielRegisRohellecTerzieff : UnitCard
    {
        public EmielRegisRohellecTerzieff()
        {
            Name = "Emiel Regis Rohellec Terzieff";
            Description = "Men, the polite ones, at least, would call me a monster. A blood-drinking freak.";
            StrengthValueOriginal = 5;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.CLOSE };
            Hero = false;
            Category = Category.NEUTRAL;
        }
    }
}
