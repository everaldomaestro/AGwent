#nullable disable
using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Factions.Monsters
{
    public sealed class CroneWeavess : UnitCard
    {
        public CroneWeavess()
        {
            Name = "Crone: Weavess";
            Description = "I sense your pain. I see your fear...";
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
