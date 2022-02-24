using AGwent.Models.Cards.Base;
using AGwent.Models.Game;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.Abilities
{
    public sealed class Decoy : Ability
    {
        public Decoy()
        {
            Type = TypeCard.SPECIAL;
            Name = "Decoy";
            Description = "When you run out of peasants, decoys also make decent arrow fodder.";
        }

        public override void RunAbility(Gwent game, PlayerNumber player, Card card, Row? row = null)
        {
            
        }
    }
}
