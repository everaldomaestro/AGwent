#nullable disable
using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Factions.Monsters
{
    public sealed class Arachas : UnitCard
    {
        public Arachas()
        {
            Name = "Arachas";
            Description = "Ugly - nature's way of saying 'Stay the fuck away.";
            StrengthValueOriginal = 4;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.CLOSE };
            Hero = false;
            Category = Category.FACTION;
            Faction = new Factories.Factions.Monsters();
            Ability = new Abilities.Muster();
            Count = 3;
        }
    }
}
