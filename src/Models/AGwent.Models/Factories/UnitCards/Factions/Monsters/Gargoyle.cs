#nullable disable
using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Factions.Monsters
{
    public sealed class Gargoyle : UnitCard
    {
        public Gargoyle()
        {
            Name = "Gargoyle";
            Description = "Ancient sculptors' nightmarish fantasies, brought to life by bored mages.";
            StrengthValueOriginal = 2;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.RANGED };
            Hero = false;
            Category = Category.FACTION;
            Faction = new Factories.Factions.Monsters();
        }
    }
}
