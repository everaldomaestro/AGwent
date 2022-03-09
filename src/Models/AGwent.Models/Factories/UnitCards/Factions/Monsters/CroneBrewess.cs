#nullable disable
using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Factions.Monsters
{
    public sealed class CroneBrewess : UnitCard
    {
        public CroneBrewess()
        {
            Name = "Crone: Brewess";
            Description = "We'll cut you up, boy. A fine broth you will make.";
            StrengthValueOriginal = 6;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.CLOSE };
            Hero = false;
            Category = Category.FACTION;
            Faction = new Factories.Factions.Monsters();
            Ability = new Abilities.Muster();
        }
    }
}
