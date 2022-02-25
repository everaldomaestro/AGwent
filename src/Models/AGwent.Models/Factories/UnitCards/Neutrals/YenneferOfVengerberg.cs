using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Neutrals
{
    public sealed class YenneferOfVengerberg : UnitCard
    {
        public YenneferOfVengerberg()
        {
            Name = "Yennefer of Vengerberg";
            Description = "Magic is Chaos, Art and Science. It is a curse, a blessing and a progression.";
            StrengthValueOriginal = 7;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.RANGED };
            Hero = true;
            Category = Category.NEUTRAL;
            Ability = new Abilities.Medic();
        }
    }
}
