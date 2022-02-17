using AGwent.Models.Cards;
using AGwent.Models.Others;
using System.Diagnostics;

namespace AGwent.Models.Game
{
    public class BattleFieldWeather
    {
        public BattleFieldWeather()
        {
            StatusCard = StatusCard.BATTLE;
            Weaters = new List<SpecialCard>();
        }

        public StatusCard StatusCard { get; private set; }
        public IList<SpecialCard> Weaters { get; private set; }

        public void AddSpecialCard(SpecialCard specialCard)
        {
            specialCard.UpdateStatus(StatusCard);
            Weaters.Add(specialCard);

            var msg = $"{specialCard.Name} add to {StatusCard}.";

            Debug.WriteLine(msg);
        }

        public void RemoveAll()
        {
            var weathers = this.Weaters.ToList();
            foreach (var weather in weathers)
            {
                RemoveSpecialCard(weather);
            }
        }

        private void RemoveSpecialCard(SpecialCard specialCard)
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
