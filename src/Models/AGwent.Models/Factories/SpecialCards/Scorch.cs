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
            Description = "Pillars of flame turn the mightiest to ash. All others tremble in shock and awe.";
            Category = Category.NEUTRAL;
            Copy = 2;
        }
    }
}
