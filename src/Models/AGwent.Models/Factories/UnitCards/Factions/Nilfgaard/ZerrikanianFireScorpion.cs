using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Factions.NorthernRealms
{
    public sealed class ZerrikanianFireScorpion : UnitCard
    {
        public ZerrikanianFireScorpion()
        {
            Name = "Zerrikanian Fire Scorpion";
            Description = "The Zerrikanian desert used to be a lush garden. Then these came along.";
            StrengthValueOriginal = 5;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.SIEGE };
            Hero = false;
            Category = Category.FACTION;
            Faction = new Factories.Factions.Nilfgaard();
        }
    }
}
