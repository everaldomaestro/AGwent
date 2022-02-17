using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Neutrals
{
    public class CirillaFionaElenRiannon : UnitCard
    {
        public CirillaFionaElenRiannon()
        {
            Name = "Cirilla Fiona Elen Riannon";
            Description = "";
            StrengthValueOriginal = 15;
            Ranges = new Row[] { Row.CLOSE };
            Hero = true;
            Category = Category.NEUTRAL;
        }
    }
}
