#nullable disable
using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Factions.Monsters
{
    public sealed class Werewolf : UnitCard
    {
        public Werewolf()
        {
            Name = "Werewolf";
            Description = "Wolves aren't as bad as they say. Werewolves, though - they're worse.";
            StrengthValueOriginal = 5;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.CLOSE };
            Hero = false;
            Category = Category.FACTION;
            Faction = new Factories.Factions.Monsters();
        }
    }
}
