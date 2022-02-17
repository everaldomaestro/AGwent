using AGwent.Models.Cards;
using AGwent.Models.Cards.Base;
using AGwent.Models.Others;

namespace AGwent.Models.Factories
{
    public static class CardFactory
    {
        public static List<UnitCard> GetUnitCards(IList<Card> cards)
        {
            var unitCards = new List<UnitCard>();

            var cardsFiltered = cards.Where(x => x.Type == TypeCard.UNIT).ToList();
            foreach (var card in cardsFiltered)
            {
                unitCards.Add((UnitCard)card);
            }

            return unitCards;
        }

        public static List<SpecialCard> GetSpecialCards(IList<Card> cards)
        {
            var specialCard = new List<SpecialCard>();

            var cardsFiltered = cards.Where(x => x.Type == TypeCard.SPECIAL).ToList();
            foreach (var card in cardsFiltered)
            {
                specialCard.Add((SpecialCard)card);
            }

            return specialCard;
        }
    }
}
