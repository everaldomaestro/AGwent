using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Factions.NorthernRealms
{
    public class SiegfriedOfDenesle : UnitCard
    {
        public SiegfriedOfDenesle()
        {
            Name = "Siegfried of Denesle";
            Description = "We're on the same side, witcher. You'll realize this one day.";
            StrengthValueOriginal = 5;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.CLOSE };
            Hero = false;
            Category = Category.FACTION;
        }
    }
}
