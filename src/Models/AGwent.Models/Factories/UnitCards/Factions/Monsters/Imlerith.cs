#nullable disable
using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Factions.Monsters
{
    public sealed class Imlerith : UnitCard
    {
        public Imlerith()
        {
            Name = "Imlerith";
            Description = "Ladd nahw! Kill them! Litter the earth with their entrails!";
            StrengthValueOriginal = 10;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.CLOSE };
            Hero = true;
            Category = Category.FACTION;
            Faction = new Factories.Factions.Monsters();
        }
    }
}
