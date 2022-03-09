#nullable disable
using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Factions.Monsters
{
    public sealed class Draug : UnitCard
    {
        public Draug()
        {
            Name = "Draug";
            Description = "Some men cannot admit defeat. Some keep fighting from beyond the grave.";
            StrengthValueOriginal = 10;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.CLOSE };
            Hero = true;
            Category = Category.FACTION;
            Faction = new Factories.Factions.Monsters();
        }
    }
}
