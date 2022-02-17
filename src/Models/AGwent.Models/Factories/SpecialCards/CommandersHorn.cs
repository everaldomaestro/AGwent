using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.SpecialCards
{
    public class CommandersHorn : SpecialCard
    {
        public CommandersHorn()
        {
            Ability = new Abilities.CommandersHorn(this.Type);
            Name = Ability.Name;
            Description = Ability.Description;
            Category = Category.NEUTRAL;
        }
    }
}
