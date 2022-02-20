using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.SpecialCards
{
    public sealed class ClearWeather : SpecialCard
    {
        public ClearWeather()
        {
            Ability = new Abilities.ClearWeather();
            Name = Ability.Name;
            Description = Ability.Description;
            Category = Category.NEUTRAL;
        }
    }
}
