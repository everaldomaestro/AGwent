using AGwent.Models.Cards.Base;
using AGwent.Models.Game;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.Abilities
{
    public sealed class Spy : Ability
    {
        public Spy()
        {
            Type = TypeCard.UNIT;
            Name = "Spy";
            Description = "Place on your opponent's battlefield (counts towards opponent's total) and draw 2 cards from your deck.";
        }

        public override void RunAbility(Gwent game, PlayerNumber player, Card card, Row? row = null)
        {
            game.GetAnotherPlayer(player).PlayCard(card, row.GetValueOrDefault());
            var spy = game.GetPlayer(player).Deck.GetCardsSpy();
            spy.ForEach(x=> game.GetPlayer(player).GetCardFromDeck(x));
        }
    }
}