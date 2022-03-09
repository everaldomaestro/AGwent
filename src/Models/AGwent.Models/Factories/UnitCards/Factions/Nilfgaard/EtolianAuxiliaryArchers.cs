using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Factions.NorthernRealms
{
    public sealed class EtolianAuxiliaryArchers : UnitCard
    {
        public EtolianAuxiliaryArchers()
        {
            Name = "Etolian Auxiliary Archers";
            Description = "Double or nothing, aim for his cock.";
            StrengthValueOriginal = 1;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.RANGED };
            Hero = false;
            Category = Category.FACTION;
            Faction = new Factories.Factions.Nilfgaard();
            Ability = new Abilities.Medic();
            Count = 2;
        }
    }
}
