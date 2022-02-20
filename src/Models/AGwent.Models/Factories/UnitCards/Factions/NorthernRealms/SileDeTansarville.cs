using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Factions.NorthernRealms
{
    public sealed class SileDeTansarville : UnitCard
    {
        public SileDeTansarville()
        {
            Name = "Síle de Tansarville";
            Description = "The Lodge lacks humility. Our lust for power may yet be our undoing.";
            StrengthValueOriginal = 5;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.RANGED };
            Hero = false;
            Category = Category.FACTION;
        }
    }
}
