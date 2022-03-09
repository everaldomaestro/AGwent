#nullable disable
using AGwent.Models.Cards;
using AGwent.Models.Cards.Base;
using AGwent.Models.Others;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

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
        
        public static List<Card> GenerateCards()
        {
            var listCards = new List<Card>();
            var cards =
                typeof(Card)
                .Assembly.GetTypes()
                .Where(t => t.IsSubclassOf(typeof(Card)) && !t.IsAbstract)
                .Select(t => (Card)Activator.CreateInstance(t))
                .ToList();

            var factions =
                typeof(Faction)
                .Assembly.GetTypes()
                .Where(t => t.IsSubclassOf(typeof(Faction)) && !t.IsAbstract)
                .Select(t => (Faction)Activator.CreateInstance(t))
                .ToList();

            var unitCards = CardFactory.GetUnitCards(cards);
            foreach (var card in unitCards)
            {
                if (card.Category == Category.FACTION && card.Name != null)
                {
                    if (card.Count == 1 && card.Copy == 0)
                    {
                        card.SetSpriteName($"{card.GetSpriteName()}");
                        listCards.Add(card);
                    }
                    else if (card.Count > 1 && card.Copy == 0)
                    {
                        card.SetSpriteName($"{card.GetSpriteName()}-1");
                        listCards.Add(card);

                        for (int i = 2; i <= card.Count; i++)
                        {
                            Type type = card.GetType();
                            var copy = (UnitCard)Activator.CreateInstance(type);
                            copy.SetSpriteName($"{copy.GetSpriteName()}-{i}");
                            listCards.Add(copy);
                        }
                    }
                    else if (card.Count == 0 && card.Copy > 0)
                    {
                        for (int i = 0; i <= card.Copy; i++)
                        {
                            Type type = card.GetType();
                            var copy = (UnitCard)Activator.CreateInstance(type);
                            listCards.Add(copy);
                        }
                    }
                }
                else if (card.Category == Category.NEUTRAL && card.Name != null)
                {
                    foreach (var faction in factions)
                    {
                        Type type = card.GetType(); 
                        var copy = (UnitCard)Activator.CreateInstance(type);
                        copy.Faction = faction;
                        copy.SetSpriteName($"{copy.GetSpriteName()}-{faction.Name.ToLower().Replace(' ', '-')}");

                        listCards.Add(copy);
                    }
                }
            }

            var specialCards = CardFactory.GetSpecialCards(cards);
            foreach (var card in specialCards)
            {
                if (card.Name != null)
                {
                    foreach (var faction in factions)
                    {
                        for (int i = 0; i <= card.Copy; i++)
                        {
                            Type type = card.GetType();
                            var copy = (SpecialCard)Activator.CreateInstance(type);
                            copy.Faction = faction;
                            copy.SetSpriteName($"{copy.GetSpriteName()}-{faction.Name.ToLower().Replace(' ', '-')}");

                            listCards.Add(copy);
                        }
                    }
                }
            }


            return listCards;
        }
    }
}
