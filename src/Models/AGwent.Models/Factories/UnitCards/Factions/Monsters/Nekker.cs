#nullable disable
using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Factions.Monsters
{
    public sealed class Nekker : UnitCard
    {
        public Nekker()
        {
            Name = "Nekker";
            Description = "Damn things are almost cute, if you ignore the whole vicious killer aspect.";
            StrengthValueOriginal = 2;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.CLOSE };
            Hero = false;
            Category = Category.FACTION;
            Ability = new Abilities.Muster();
        }
    }
}
