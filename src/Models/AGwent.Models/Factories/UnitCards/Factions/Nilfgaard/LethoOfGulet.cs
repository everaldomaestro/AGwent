using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Factions.NorthernRealms
{
    public sealed class LethoOfGulet : UnitCard
    {
        public LethoOfGulet()
        {
            Name = "Letho of Gulet";
            Description = "Witchers never die in their beds.";
            StrengthValueOriginal = 10;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.CLOSE };
            Hero = true;
            Category = Category.FACTION;
            Faction = new Factories.Factions.Nilfgaard();
        }
    }
}
