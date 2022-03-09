using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.SpecialCards
{
    public sealed class CommandersHorn : SpecialCard
    {
        public CommandersHorn()
        {
            Ability = new Abilities.CommandersHorn(this.Type);
            Name = Ability.Name;
            Description = "Plus one to morale, minus three to hearing.";
            Category = Category.NEUTRAL;
            Copy = 2;
        }
    }
}
