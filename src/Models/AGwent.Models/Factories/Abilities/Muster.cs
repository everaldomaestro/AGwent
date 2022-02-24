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

        public override void RunAbility(Gwent game, PlayerNumber player, Card card, Row? row = null)
        {
            var unitCard = (UnitCard)card;

            var hand = game.GetPlayer(player).Hand.Cards.Where(x => x.Name.Contains(card.Name.Split(' ')[0]) && x.Ability.GetType() == card.Ability.GetType() && x.StatusCard == StatusCard.HAND).Cast<UnitCard>().ToList();
            var deck = game.GetPlayer(player).Deck.Cards.Where(x => x.Name.Contains(card.Name.Split(' ')[0]) && x.Ability.GetType() == card.Ability.GetType() && x.StatusCard == StatusCard.DECK).Cast<UnitCard>().ToList();

            hand.ForEach(x => game.GetPlayer(player).Hand.RemoveCard(x));
            deck.ForEach(x => game.GetPlayer(player).Deck.RemoveCard(x));

            hand.ForEach(x => x.UpdateStatus(null));
            deck.ForEach(x => x.UpdateStatus(null));

            hand.ForEach(x => x.PlayCard(game, x.Ranges[0], player));
            deck.ForEach(x => x.PlayCard(game, x.Ranges[0], player));            
        }
    }
}
