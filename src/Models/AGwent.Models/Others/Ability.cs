using AGwent.Models.Game;

namespace AGwent.Models.Others
{
    public abstract class Ability
    {
        //Properties
        public TypeCard Type { get; protected set; }
        public string Name { get; protected set; }
        public string Description { get; protected set; }

        public abstract void RunAbility(Gwent game, Row? row, PlayerNumber player);
    }
}
