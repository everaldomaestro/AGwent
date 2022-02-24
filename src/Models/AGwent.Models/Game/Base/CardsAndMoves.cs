using AGwent.Models.Cards.Base;
using AGwent.Models.Others;
using System.Diagnostics;

namespace AGwent.Models.Game.Base
{
    public abstract class CardsAndMoves
    {
        protected CardsAndMoves(StatusCard statusCard)
        {
            StatusCard = statusCard;
            Cards = new List<Card>();
        }

        public StatusCard StatusCard { get; protected set; }
        public IList<Card> Cards { get; protected set; }

        public void AddCard(Card card)
        {
            card.UpdateStatus(StatusCard);
            Cards.Add(card);

            var msg = $"{card.Name} add to {StatusCard}.";
            Debug.WriteLine(msg);
        }

        public void RemoveAllSpecialCards()
        {
            var specialCards = this.Cards.Where(x => x.Type == TypeCard.SPECIAL).ToList();
            foreach (var weather in specialCards)
            {
                RemoveCard(weather);
            }
        }

        public void RemoveCard(Card card)
        {
            if (Cards.Contains(card))
            {
                card.UpdateStatus(StatusCard);
                Cards.Remove(card);

                var msg = $"{card.Name} remove from {StatusCard}.";
                Debug.WriteLine(msg);
            }
        }
    }
}
