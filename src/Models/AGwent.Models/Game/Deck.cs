using AGwent.Models.Cards.Base;
using AGwent.Models.Game.Base;
using AGwent.Models.Others;

namespace AGwent.Models.Game
{
    public class Deck : CardsAndMoves
    {
        public Deck() : base(StatusCard.DECK)
        {
        }

        public List<Card> GetCardsSpy()
        {
            var rand = new Random();
            var cards = new List<Card>();
            var maxIndex = this.Cards.Count - 1;

            cards.Add(Cards.ElementAt(rand.Next(0, maxIndex)));
            cards.Add(Cards.ElementAt(rand.Next(0, --maxIndex)));

            return cards;
        }
    }
}
