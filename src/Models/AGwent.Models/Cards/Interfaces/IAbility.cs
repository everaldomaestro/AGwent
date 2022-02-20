using AGwent.Models.Game;
using AGwent.Models.Others;

namespace AGwent.Models.Cards.Interfaces
{
    public interface IAbility
    {
        void RunAbility(Gwent game, Row? row, PlayerNumber player);
    }
}
