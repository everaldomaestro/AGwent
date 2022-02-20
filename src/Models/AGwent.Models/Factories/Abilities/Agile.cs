using AGwent.Models.Game;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.Abilities
{
    public sealed class Agile : Ability
    {
        public Agile()
        {
            Type = TypeCard.SPECIAL;
            Name = "Agile";
            Description = "Can be placed in either the Close Combat or the Ranged Combat row. Cannot be moved once placed.";
        }

        public override void RunAbility(Gwent game, Row? row, PlayerNumber player)
        {
            //TODO: destacar opções de locais para jogar
        }
    }
}
