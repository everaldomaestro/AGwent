using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.SpecialCards
{
    public sealed class ImpenetrableFog : SpecialCard
    {
        public ImpenetrableFog()
        {
            Ability = new Abilities.ImpenetrableFog();
            Name = Ability.Name;
            Description = "A good commander's dream... a bad one's horror.";
            Category = Category.NEUTRAL;
            Copy = 2;
        }
    }
}
