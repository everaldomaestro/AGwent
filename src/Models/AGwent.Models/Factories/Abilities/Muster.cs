#nullable disable
using AGwent.Models.Cards;
using AGwent.Models.Cards.Base;
using AGwent.Models.Game;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.Abilities
{
    public sealed class Muster : Ability
    {
        public Muster()
        {
            Type = TypeCard.SPECIAL;
            Name = "Muster";
            Description = "Find any cards with the same name in your deck and play them instantly.";
        }

        public override void RunAbility(Gwent game, PlayerNumber player, Card card, Row? row)
        {
            var unitCard = (UnitCard)card;

            if (player == PlayerNumber.ONE)
            {
                var hand = game.PlayerOne.Hand.Cards.Where(x => x.Name.Contains(card.Name.Split(' ')[0]) && x.Ability.GetType() == card.Ability.GetType() && x.StatusCard == StatusCard.HAND).Cast<UnitCard>().ToList();
                var deck = game.PlayerOne.Deck.Cards.Where(x => x.Name.Contains(card.Name.Split(' ')[0]) && x.Ability.GetType() == card.Ability.GetType() && x.StatusCard == StatusCard.DECK).Cast<UnitCard>().ToList();

                hand.ForEach(x => game.PlayerOne.Hand.RemoveCard(x));
                deck.ForEach(x => game.PlayerOne.Deck.RemoveCard(x));

                hand.ForEach(x => x.UpdateStatus(null));
                deck.ForEach(x => x.UpdateStatus(null));

                hand.ForEach(x => x.PlayCard(game, x.Ranges[0], player));
                deck.ForEach(x => x.PlayCard(game, x.Ranges[0], player));
            }
            else
            {
                var hand = game.PlayerTwo.Hand.Cards.Where(x => x.Name.Contains(card.Name.Split(' ')[0]) && x.Ability.GetType() == card.Ability.GetType() && x.StatusCard == StatusCard.HAND).Cast<UnitCard>().ToList();
                var deck = game.PlayerTwo.Deck.Cards.Where(x => x.Name.Contains(card.Name.Split(' ')[0]) && x.Ability.GetType() == card.Ability.GetType() && x.StatusCard == StatusCard.DECK).Cast<UnitCard>().ToList();

                hand.ForEach(x => game.PlayerTwo.Hand.RemoveCard(x));
                deck.ForEach(x => game.PlayerTwo.Deck.RemoveCard(x));

                hand.ForEach(x => x.UpdateStatus(null));
                deck.ForEach(x => x.UpdateStatus(null));

                hand.ForEach(x => x.PlayCard(game, x.Ranges[0], player));
                deck.ForEach(x => x.PlayCard(game, x.Ranges[0], player));
            }
        }
    }
}
