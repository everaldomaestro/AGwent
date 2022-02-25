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
            Description = "The sun's shinin', Dromle! The sun's shinin'! Maybe there's hope left after all...";
            Category = Category.NEUTRAL;
        }
    }
}
