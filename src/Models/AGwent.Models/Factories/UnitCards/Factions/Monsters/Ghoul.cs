#nullable disable
using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Factions.Monsters
{
    public sealed class Ghoul : UnitCard
    {
        public Ghoul()
        {
            Name = "Ghoul";
            Description = "If ghouls are part of the Circle of Life... then it's a damn vicious circle.";
            StrengthValueOriginal = 1;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.CLOSE };
            Hero = false;
            Category = Category.FACTION;
            Ability = new Abilities.Muster();
        }
    }
}
