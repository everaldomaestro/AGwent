#nullable disable
using AGwent.Models.Cards;
using AGwent.Models.Cards.Base;
using AGwent.Models.Others;

namespace AGwent.Models.Factories
{
    public static class CardFactory
    {
        public static List<UnitCard> GetUnitCards(IList<Card> cards)
        {
            return cards.Where(x => x.Type == TypeCard.UNIT).Cast<UnitCard>().ToList();
        }

        public static List<SpecialCard> GetSpecialCards(IList<Card> cards)
        {
            return cards.Where(x => x.Type == TypeCard.SPECIAL).Cast<SpecialCard>().ToList();
        }

        public static List<T> GetCards<T>(IList<Card> cards) where T : class
        {
            return cards.Where(x => x.GetType().BaseType.Equals(typeof(T))).Cast<T>().ToList();
        }
    }
}
