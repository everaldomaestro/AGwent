using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Factions.NorthernRealms
{
    public sealed class SiegeTechnician : UnitCard
    {
        public SiegeTechnician()
        {
            Name = "Siege Technician";
            Description = "Discipline is the Empire's greatest weapon";
            StrengthValueOriginal = 0;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.SIEGE };
            Hero = false;
            Category = Category.FACTION;
            Faction = new Factories.Factions.Nilfgaard();
            Ability = new Abilities.Medic();
        }
    }
}
