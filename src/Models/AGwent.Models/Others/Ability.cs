using AGwent.Models.Cards.Base;
using AGwent.Models.Cards.Interfaces;
using AGwent.Models.Game;

namespace AGwent.Models.Others
{
    public abstract class Ability : IAbility
    {
        //Properties
        public TypeCard Type { get; protected set; }
        public string Name { get; protected set; }
        public string Description { get; protected set; }

        public virtual void RunAbility(Gwent game, PlayerNumber player, Card card, Row? row = null)
        {
            throw new NotImplementedException();
        }
    }
}
