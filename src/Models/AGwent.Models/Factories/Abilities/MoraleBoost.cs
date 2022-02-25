using AGwent.Models.Cards.Base;
using AGwent.Models.Game;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.Abilities
{
    public sealed class MoraleBoost : Ability
    {
        public MoraleBoost()
        {
            Type = TypeCard.UNIT;
            Name = "Morale Boost";
            Description = "Adds +1 to all units on the row (excluding itself).";
        }

        public override void RunAbility(Gwent game, PlayerNumber player, Card card, Row? row = null)
        {
            base.RunAbility(game, player, card, row);
        }
    }
}
