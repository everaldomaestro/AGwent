using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.SpecialCards
{
    public sealed class Scorch : SpecialCard
    {
        public Scorch()
        {
            Ability = new Abilities.Scorch(this.Type);
            Name = Ability.Name;
            Description = Ability.Description;
            Category = Category.NEUTRAL;
        }
    }
}
