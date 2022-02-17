using AGwent.Models.Game.Base;
using AGwent.Models.Others;

namespace AGwent.Models.Game
{
    public class BattleFieldRow : CardsAndMoves
    {
        public BattleFieldRow(Row row): base(StatusCard.BATTLE)
        {
            TotalStrengthValue = 0;
            Row = row;
        }

        public int TotalStrengthValue { get; private set; }
        public Row Row { get; private set; }
    }
}