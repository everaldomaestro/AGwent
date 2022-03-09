using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Factions.NorthernRealms
{
    public sealed class SigismundDijkstra : UnitCard
    {
        public SigismundDijkstra()
        {
            Name = "Sigismund Dijkstra";
            Description = "Gwent's like politics, just more honest.";
            StrengthValueOriginal = 4;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.CLOSE };
            Hero = false;
            Category = Category.FACTION;
            Faction = new Factories.Factions.NorthernRealms();
            Ability = new Abilities.Spy();
        }
    }
}
