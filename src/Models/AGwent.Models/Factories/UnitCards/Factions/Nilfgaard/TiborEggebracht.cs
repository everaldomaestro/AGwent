using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Factions.NorthernRealms
{
    public sealed class TiborEggebracht : UnitCard
    {
        public TiborEggebracht()
        {
            Name = "Tibor Eggebracht";
            Description = "Albaaaa! Forward! Alba! Long live the Emperor!";
            StrengthValueOriginal = 10;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.RANGED };
            Hero = true;
            Category = Category.FACTION;
            Faction = new Factories.Factions.Nilfgaard();
        }
    }
}
