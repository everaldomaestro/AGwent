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
            Description = "Best part about frost - bodies of the fallen don't rot so quickly.";
            Category = Category.NEUTRAL;
            Copy = 2;
        }
    }
}
