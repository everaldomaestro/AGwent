using AGwent.Models.Cards;
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

        public void AddCard(SpecialCard specialCard)
        {
            specialCard.UpdateStatus(StatusCard);
            Cards.Add(specialCard);

            var msg = $"{specialCard.Name} add to {StatusCard}.";

            Debug.WriteLine(msg);
        }

        public void AddCard(UnitCard unitCard)
        {
            unitCard.UpdateStatus(StatusCard);
            Cards.Add(unitCard);

            var msg = $"{unitCard.Name} add to {StatusCard}.";
            Debug.WriteLine(msg);
        } 

        public void RemoveCard(SpecialCard specialCard)
        {
            if (Cards.Contains(specialCard))
            {
                specialCard.UpdateStatus(StatusCard);
                Cards.Remove(specialCard);

                var msg = $"{specialCard.Name} remove from {StatusCard}.";
                Debug.WriteLine(msg);
            }
        }

        public void RemoveCard(UnitCard unitCard)
        {
            if (Cards.Contains(unitCard))
            {
                unitCard.UpdateStatus(StatusCard);
                Cards.Remove(unitCard);

                var msg = $"{unitCard.Name} remove from {StatusCard}.";
                Debug.WriteLine(msg);
            }
        }
    }
}
