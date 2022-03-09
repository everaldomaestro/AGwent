using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Factions.NorthernRealms
{
    public sealed class JohnNatalis : UnitCard
    {
        public JohnNatalis()
        {
            Name = "John Natalis";
            Description = "That square should bear the names of my soldiers, of the dead. Not mine.";
            StrengthValueOriginal = 10;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.CLOSE };
            Hero = true;
            Category = Category.FACTION;
            Faction = new Factories.Factions.NorthernRealms();
        }
    }
}
