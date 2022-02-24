#nullable disable
using AGwent.Models.Cards.Base;
using AGwent.Models.Others;

namespace AGwent.Models.Game
{
    public class BattleField
    {
        public BattleField(BattleFieldWeather battleFieldWeather)
        {
            BattleFieldWeather = battleFieldWeather;

            Hand = new Hand();
            Discard = new Discard();
            Deck = new Deck();

            BattleFieldRow = new List<BattleFieldRow>
            {
                new BattleFieldRow(Row.CLOSE),
                new BattleFieldRow(Row.RANGED),
                new BattleFieldRow(Row.SIEGE)
            };
        }

        public Player Player { get; private set; }
        public Hand Hand { get; private set; }
        public Discard Discard { get; private set; }
        public Deck Deck { get; private set; }
        public IList<BattleFieldRow> BattleFieldRow { get; private set; }

        //Navigation
        public BattleFieldWeather BattleFieldWeather { get; private set; }

        //Actions
        public void SetPlayer(Player player)
        {
            Player = player;
        }

        public void PlayCard(Card card, Row row)
        {
            Hand.RemoveCard(card);
            BattleFieldRow.FirstOrDefault(x => x.Row == row).AddCard(card);
        }

        public void DiscardCard(Card card)
        {
            BattleFieldRow.ToList().ForEach(x => x.RemoveCard(card));
            Discard.AddCard(card);
        }
    }
}
