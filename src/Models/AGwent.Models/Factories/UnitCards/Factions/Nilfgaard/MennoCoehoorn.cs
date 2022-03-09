using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Factions.NorthernRealms
{
    public sealed class MennoCoehoorn : UnitCard
    {
        public MennoCoehoorn()
        {
            Name = "Menno Coehoorn";
            Description = "I'll take an attentive reconnaissance unit over a line cavalry brigade any day.";
            StrengthValueOriginal = 10;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.CLOSE };
            Hero = true;
            Category = Category.FACTION;
            Faction = new Factories.Factions.Nilfgaard();
            Ability = new Abilities.Medic();
        }
    }
}
