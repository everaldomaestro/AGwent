#nullable disable
using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Factions.Monsters
{
    public sealed class VampireFleder : UnitCard
    {
        public VampireFleder()
        {
            Name = "Vampire: Fleder";
            Description = "Higher vampires embrace their victims. Fleders rip them to shreds.";
            StrengthValueOriginal = 4;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.CLOSE };
            Hero = false;
            Category = Category.FACTION;
            Faction = new Factories.Factions.Monsters();
            Ability = new Abilities.Muster();
        }
    }
}
