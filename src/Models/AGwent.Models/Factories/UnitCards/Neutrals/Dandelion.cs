using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Neutrals
{
    public sealed class Dandelion : UnitCard
    {
        public Dandelion()
        {
            Name = "Dandelion";
            Description = "Dandelion, you're a cynic, a lecher, a whoremonger, a liar - and my best friend.";
            StrengthValueOriginal = 2;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.CLOSE };
            Hero = false;
            Category = Category.NEUTRAL;
            Ability = new Abilities.CommandersHorn(Type);
        }
    }
}
