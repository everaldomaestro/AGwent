using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Factions.Scoiatael
{
    public sealed class MahakamanDefender : UnitCard
    {
        public MahakamanDefender()
        {
            Name = "Mahakaman Defender";
            Description = "I'm telling ye, we're born fer battle - we slash straight at their knees!";
            StrengthValueOriginal = 5;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.CLOSE };
            Hero = false;
            Category = Category.FACTION;
            Faction = new Factories.Factions.Scoiatael();
            Count = 5;
        }
    }
}
