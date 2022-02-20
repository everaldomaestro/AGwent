using AGwent.Models.Cards;
using AGwent.Models.Game.Interfaces;
using AGwent.Models.Others;
using System.Diagnostics;

namespace AGwent.Models.Game
{
    public class BattleFieldWeather : ISpecialCardMoves
    {
        public BattleFieldWeather()
        {
            StatusCard = StatusCard.BATTLE;
            Weaters = new List<SpecialCard>();
        }

        public StatusCard StatusCard { get; private set; }
        public IList<SpecialCard> Weaters { get; private set; }

        public void AddCard(SpecialCard specialCard)
        {
            specialCard.UpdateStatus(StatusCard);
            Weaters.Add(specialCard);

            var msg = $"{specialCard.Name} add to {StatusCard}.";

            Debug.WriteLine(msg);
        }

        public void RemoveAllSpecialCards()
        {
            var weathers = this.Weaters.ToList();
            foreach (var weather in weathers)
            {
                RemoveCard(weather);
            }
        }

        public void RemoveCard(SpecialCard specialCard)
        {
            if (Weaters.Contains(specialCard))
            {
                specialCard.UpdateStatus(null);
                Weaters.Remove(specialCard);

                var msg = $"{specialCard.Name} remove from {StatusCard}.";

                Debug.WriteLine(msg);
            }
        }
    }
}
