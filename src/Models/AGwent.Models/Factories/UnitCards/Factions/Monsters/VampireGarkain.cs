#nullable disable
using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Factions.Monsters
{
    public sealed class VampireGarkain : UnitCard
    {
        public VampireGarkain()
        {
            Name = "Vampire: Garkain";
            Description = "Blood-drinkers and corpse-eaters so foul, their very ugliness paralyses foes.";
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
