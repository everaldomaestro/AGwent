using AGwent.Models.Game.Base;
using AGwent.Models.Others;

namespace AGwent.Models.Game
{
    public class Hand : CardsAndMoves
    {
        public Hand() : base(StatusCard.HAND)
        {
        }
    }
}

