using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.SpecialCards
{
    public sealed class TorrentialRain : SpecialCard
    {
        public TorrentialRain()
        {
            Ability = new Abilities.TorrentialRain();
            Name = Ability.Name;
            Description = "Even the rain in this land smells like piss.";
            Category = Category.NEUTRAL;
            Copy = 2;
        }
    }
}
