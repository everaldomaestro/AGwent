using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Factions.Scoiatael
{
    public sealed class DennisCranmer : UnitCard
    {
        public DennisCranmer()
        {
            Name = "Dennis Cranmer";
            Description = "I know how to carry out orders, so you can shove you advice up your coal chute.";
            StrengthValueOriginal = 6;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.CLOSE};
            Hero = false;
            Category = Category.FACTION;
            Faction = new Factories.Factions.Scoiatael();
        }
    }
}
