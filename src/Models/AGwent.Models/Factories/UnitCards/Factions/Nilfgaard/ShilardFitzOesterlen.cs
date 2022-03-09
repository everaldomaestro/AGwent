using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Factions.NorthernRealms
{
    public sealed class ShilardFitzOesterlen : UnitCard
    {
        public ShilardFitzOesterlen()
        {
            Name = "Shilard Fitz-Oesterlen";
            Description = "Warfare is mere sound and fury - diplomacy is what truly shapes history";
            StrengthValueOriginal = 7;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.CLOSE };
            Hero = false;
            Category = Category.FACTION;
            Faction = new Factories.Factions.Nilfgaard();
            Ability = new Abilities.Spy();
        }
    }
}
