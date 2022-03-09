using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Factions.NorthernRealms
{
    public sealed class YoungEmissary : UnitCard
    {
        public YoungEmissary()
        {
            Name = "Young Emissary";
            Description = "If I acquit myself well, perhaps next they'll post me somewhere civilized";
            StrengthValueOriginal = 5;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.CLOSE };
            Hero = false;
            Category = Category.FACTION;
            Faction = new Factories.Factions.Nilfgaard();
            Ability = new Abilities.TightBond();
            Count = 2;
        }
    }
}
