using AGwent.Models.Game.Base;
using AGwent.Models.Others;

namespace AGwent.Models.Game
{
    public class Discard : CardsAndMoves
    {
        public Discard() : base(StatusCard.DISCARD)
        {
        }
    }
}
