using AGwent.Models.Cards.Base;
using AGwent.Models.Game;
using AGwent.Models.Others;

namespace AGwent.Models.Cards.Interfaces
{
    public interface IAbility
    {
        void RunAbility(Gwent game, PlayerNumber player, Card card, Row? row = null);
    }
}
