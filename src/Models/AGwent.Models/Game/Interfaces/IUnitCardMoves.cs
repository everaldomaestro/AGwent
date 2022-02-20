using AGwent.Models.Cards;

namespace AGwent.Models.Game.Interfaces
{
    public interface IUnitCardMoves
    {
        void AddCard(UnitCard unitCard);
        void RemoveCard(UnitCard unitCard);
    }
}
