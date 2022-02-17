using AGwent.Models.Game.Base;
using AGwent.Models.Others;

namespace AGwent.Models.Game
{
    public class Deck : CardsAndMoves
    {
        public Deck() : base(StatusCard.DECK)
        {
        }
    }
}
