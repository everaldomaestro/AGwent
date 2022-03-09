using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Factions.NorthernRealms
{
    public sealed class Morteisen : UnitCard
    {
        public Morteisen()
        {
            Name = "Morteisen";
            Description = "No Nordling pikemen or dwarven spearbearers can hope to best trained cavalry.";
            StrengthValueOriginal = 3;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.CLOSE };
            Hero = false;
            Category = Category.FACTION;
            Faction = new Factories.Factions.Nilfgaard();
        }
    }
}
