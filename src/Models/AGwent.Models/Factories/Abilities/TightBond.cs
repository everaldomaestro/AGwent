using AGwent.Models.Cards.Base;
using AGwent.Models.Game;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.Abilities
{
    public sealed class TightBond : Ability
    {
        public TightBond()
        {
            Type = TypeCard.UNIT;
            Name = "Tight Bond";
            Description = "Place next to a card with the same name to double the strength of both cards.";
        }

        public override void RunAbility(Gwent game, PlayerNumber player, Card card, Row? row = null)
        {
            base.RunAbility(game, player, card, row);
        }
    }
}
