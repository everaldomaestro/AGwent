using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Factions.NorthernRealms
{
    public sealed class EsteradThyssen : UnitCard
    {
        public EsteradThyssen()
        {
            Name = "Esterad Thyssen";
            Description = "Like all Thyssen men, he was tall, powerfully build and criminally handsome.";
            StrengthValueOriginal = 10;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.CLOSE };
            Hero = true;
            Category = Category.FACTION;
            Faction = new Factories.Factions.NorthernRealms();
        }
    }
}
