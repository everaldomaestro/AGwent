using AGwent.Models.Cards;

namespace AGwent.Models.Game.Interfaces
{
    public interface ISpecialCardMoves
    {
        void AddCard(SpecialCard specialCard);
        void RemoveCard(SpecialCard specialCard);
        void RemoveAllSpecialCards();
    }
}
