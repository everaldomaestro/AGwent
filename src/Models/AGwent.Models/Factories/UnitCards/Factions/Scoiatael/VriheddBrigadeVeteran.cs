using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Factions.Scoiatael
{
    public sealed class VriheddBrigadeVeteran : UnitCard
    {
        public VriheddBrigadeVeteran()
        {
            Name = "Vrihedd Brigade Veteran";
            Description = "Vrihedd? What's that mean? Trouble.";
            StrengthValueOriginal = 5;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.CLOSE, Row.RANGED };
            Hero = false;
            Category = Category.FACTION;
            Faction = new Factories.Factions.Scoiatael();
            Ability = new Abilities.Agile();
            Count = 2;
        }
    }
}
