using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Factions.NorthernRealms
{
    public sealed class CahirMawrDyffrynAepCeallach : UnitCard
    {
        public CahirMawrDyffrynAepCeallach()
        {
            Name = "Cahir Mawr Dyffryn aep Ceallach";
            Description = "His eyes flashed under his winged helmet. Fire gleamed from his sword's blade.";
            StrengthValueOriginal = 6;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.CLOSE };
            Hero = false;
            Category = Category.FACTION;
            Faction = new Factories.Factions.Nilfgaard();
        }
    }
}
