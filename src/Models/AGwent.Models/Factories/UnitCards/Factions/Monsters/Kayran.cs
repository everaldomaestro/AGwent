#nullable disable
using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Factions.Monsters
{
    public sealed class Kayran : UnitCard
    {
        public Kayran()
        {
            Name = "Kayran";
            Description = "Kill a kayran? Simple. Take your best sword... then sell it and hire a witcher.";
            StrengthValueOriginal = 8;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.CLOSE, Row.RANGED };
            Hero = true;
            Category = Category.FACTION;
            Faction = new Factories.Factions.Monsters();
            Ability = new Abilities.MoraleBoost();
        }
    }
}
