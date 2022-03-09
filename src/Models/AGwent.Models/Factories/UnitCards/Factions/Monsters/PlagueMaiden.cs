#nullable disable
using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Factions.Monsters
{
    public sealed class PlagueMaiden : UnitCard
    {
        public PlagueMaiden()
        {
            Name = "Plague Maiden";
            Description = "The sick rave about a boil-pocked woman surrounded by herds of rabid rats...";
            StrengthValueOriginal = 5;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.CLOSE };
            Hero = false;
            Category = Category.FACTION;
            Faction = new Factories.Factions.Monsters();
        }
    }
}
