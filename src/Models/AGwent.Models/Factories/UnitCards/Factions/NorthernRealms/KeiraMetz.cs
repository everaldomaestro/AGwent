using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Factions.NorthernRealms
{
    public sealed class KeiraMetz : UnitCard
    {
        public KeiraMetz()
        {
            Name = "Keira Metz";
            Description = "If I'm to die today, I wish to look smashing for the occasion.";
            StrengthValueOriginal = 5;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.RANGED };
            Hero = false;
            Category = Category.FACTION;
            Faction = new Factories.Factions.NorthernRealms();
        }
    }
}
