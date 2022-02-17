using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Neutrals
{
    public class EmielRegisRohellecTerzieff : UnitCard
    {
        public EmielRegisRohellecTerzieff()
        {
            Name = "Emiel Regis Rohellec Terzieff";
            Description = "";
            StrengthValueOriginal = 5;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.CLOSE };
            Hero = false;
            Category = Category.NEUTRAL;
        }
    }
}
