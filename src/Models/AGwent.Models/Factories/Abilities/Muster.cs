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
            if (player == PlayerNumber.ONE)
            {
                var hand = game.PlayerOne.Hand.Cards.Where(x => x.Name.Equals(card.Name) && x.StatusCard == StatusCard.HAND).Cast<UnitCard>().ToList();
                var deck = game.PlayerOne.Deck.Cards.Where(x => x.Name.Equals(card.Name) && x.StatusCard == StatusCard.DECK).Cast<UnitCard>().ToList();

                hand.ForEach(x => x.UpdateStatus(StatusCard.BATTLE));
                deck.ForEach(x => x.UpdateStatus(StatusCard.BATTLE));
                
                var cards = new List<UnitCard>();
                hand.ForEach(x => cards.Add(x));
                deck.ForEach(x => cards.Add(x));

                var unitCard = (UnitCard)card;
                var area = unitCard.Ranges[0];

                var battleFieldRow = game.PlayerOne.BattleFieldRow.FirstOrDefault(x => x.Row == area);
                cards.ForEach(x=> battleFieldRow.AddCard(x));
            }
            else
            {
                var hand = game.PlayerTwo.Hand.Cards.Where(x => x.Name.Equals(card.Name) && x.StatusCard == StatusCard.HAND).Cast<UnitCard>().ToList();
                var deck = game.PlayerTwo.Deck.Cards.Where(x => x.Name.Equals(card.Name) && x.StatusCard == StatusCard.DECK).Cast<UnitCard>().ToList();

                hand.ForEach(x => x.UpdateStatus(StatusCard.BATTLE));
                deck.ForEach(x => x.UpdateStatus(StatusCard.BATTLE));

                var cards = new List<UnitCard>();
                hand.ForEach(x => cards.Add(x));
                deck.ForEach(x => cards.Add(x));

                var unitCard = (UnitCard)card;
                var area = unitCard.Ranges[0];

                var battleFieldRow = game.PlayerTwo.BattleFieldRow.FirstOrDefault(x => x.Row == area);
                cards.ForEach(x => battleFieldRow.AddCard(x));
            }
        }
    }
}
