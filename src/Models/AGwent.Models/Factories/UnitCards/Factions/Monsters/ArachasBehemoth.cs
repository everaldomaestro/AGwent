#nullable disable
using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Factions.Monsters
{
    public class ArachasBehemoth : UnitCard
    {
        public ArachasBehemoth()
        {
            Name = "Arachas Behemoth";
            Description = "Like a cross between a crab, a spider... and a ploughin' mountain.";
            StrengthValueOriginal = 6;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.SIEGE };
            Hero = false;
            Category = Category.FACTION;
            Ability = new Abilities.Muster();
        }
    }
}
