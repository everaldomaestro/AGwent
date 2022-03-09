using AGwent.Models.Cards;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Factions.NorthernRealms
{
    public sealed class StefanSkellen : UnitCard
    {
        public StefanSkellen()
        {
            Name = "Stefan Skellen";
            Description = "My mark scars the face of our future empress. That is my proudest achievement.";
            StrengthValueOriginal = 9;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.CLOSE };
            Hero = false;
            Category = Category.FACTION;
            Faction = new Factories.Factions.Nilfgaard();
            Ability = new Abilities.Spy();
        }
    }
}
