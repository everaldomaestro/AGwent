using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.SpecialCards
{
    public sealed class BitingFrost : SpecialCard
    {
        public BitingFrost()
        {
            Ability = new Abilities.BitingFrost();
            Name = Ability.Name;
            Description = Ability.Description;
            Category = Category.NEUTRAL;
        }
    }
}
