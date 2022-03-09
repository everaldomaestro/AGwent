using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.SpecialCards
{
    public sealed class Decoy : SpecialCard
    {
        public Decoy()
        {
            Ability = new Abilities.Decoy();
            Name = Ability.Name;
            Description = "When you have run out of peasants, decoys also make decent arrow fodder.";
            Category = Category.NEUTRAL;
            Copy = 2;
        }
    }
}
