#nullable disable
using AGwent.Models.Game;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.Abilities
{
    public sealed class CommandersHorn : Ability
    {
        public CommandersHorn(TypeCard typeCard)
        {
            Type = typeCard;
            Name = "Commander's Horn";
            Description = "Plus one to morale, minus three to hearing.";
        }

        public override void RunAbility(Gwent game, Row? row, PlayerNumber player)
        {
            if (Type == TypeCard.SPECIAL)
            {
            }
            else
            {
                if (player == PlayerNumber.ONE)
                {
                }
                else
                {
                }
            }
        }
    }
}
