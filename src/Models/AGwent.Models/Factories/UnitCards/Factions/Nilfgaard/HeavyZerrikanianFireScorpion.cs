using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Factions.NorthernRealms
{
    public sealed class HeavyZerrikanianFireScorpion : UnitCard
    {
        public HeavyZerrikanianFireScorpion()
        {
            Name = "Heavy Zerrikanian Fire Scorpion";
            Description = "Not the best for taking cities, but great for razing them to the ground.";
            StrengthValueOriginal = 10;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.SIEGE };
            Hero = false;
            Category = Category.FACTION;
            Faction = new Factories.Factions.Nilfgaard();
        }
    }
}
