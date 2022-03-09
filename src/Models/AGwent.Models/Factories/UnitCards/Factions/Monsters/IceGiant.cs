#nullable disable
using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Factions.Monsters
{
    public sealed class IceGiant : UnitCard
    {
        public IceGiant()
        {
            Name = "Ice Giant";
            Description = "Fled one time in my life. From the Ice Giant. And I'm not a bit ashamed.";
            StrengthValueOriginal = 5;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.SIEGE };
            Hero = false;
            Category = Category.FACTION;
            Faction = new Factories.Factions.Monsters();
        }
    }
}
