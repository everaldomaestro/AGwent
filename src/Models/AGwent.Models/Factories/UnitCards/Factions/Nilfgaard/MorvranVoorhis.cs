using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Factions.NorthernRealms
{
    public sealed class MorvranVoorhis : UnitCard
    {
        public MorvranVoorhis()
        {
            Name = "Morvran Voorhis";
            Description = "Summer sun reflecting in the quiet waters of the Alba - that's Nilfgaard to me.";
            StrengthValueOriginal = 10;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.SIEGE };
            Hero = true;
            Category = Category.FACTION;
            Faction = new Factories.Factions.Nilfgaard();
        }
    }
}
