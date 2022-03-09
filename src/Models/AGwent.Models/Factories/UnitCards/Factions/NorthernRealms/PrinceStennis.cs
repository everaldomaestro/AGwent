using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Factions.NorthernRealms
{
    public sealed class PrinceStennis : UnitCard
    {
        public PrinceStennis()
        {
            Name = "Prince Stennis";
            Description = "He ploughin' wears golden armor. Golden. 'Course he's an arsehole.";
            StrengthValueOriginal = 5;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.CLOSE };
            Hero = false;
            Category = Category.FACTION;
            Faction = new Factories.Factions.NorthernRealms();
            Ability = new Abilities.Spy();
        }
    }
}
