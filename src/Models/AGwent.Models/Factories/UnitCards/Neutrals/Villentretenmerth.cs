using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Neutrals
{
    public class Villentretenmerth : UnitCard
    {
        public Villentretenmerth()
        {
            Name = "Villentretenmerth";
            Description = "Scorch - Close Combat: Destroy your enemy's strongest Close Combat unit(s) if the combined strength of all his or her Close Combat units is 10 or more.";
            StrengthValueOriginal = 7;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.CLOSE };
            Hero = false;
            Category = Category.NEUTRAL;
            Ability = new Abilities.Scorch(Type);
        }
    }
}
