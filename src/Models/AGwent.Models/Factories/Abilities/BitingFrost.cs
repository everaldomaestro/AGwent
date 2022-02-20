#nullable disable
using AGwent.Models.Game;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.Abilities
{
    public sealed class BitingFrost : Ability
    {
        public BitingFrost()
        {
            Type = TypeCard.SPECIAL;
            Name = "Biting Frost";
            Description = "Place face up on the battlefield. Sets the strength of all close combat units to 1 for both players.";
        }

        public override void RunAbility(Gwent game, Row? row, PlayerNumber player)
        {
            var cardsPlayerOne = CardFactory.GetUnitCards(game.PlayerOne.BattleFieldRow.FirstOrDefault(x => x.Row == Row.CLOSE).Cards)
                .Where(x => x.AllowDamageAndDecoy()).ToList();

            cardsPlayerOne.ForEach(card => card.SetWheaterStrengthValue());

            var cardsPlayerTwo = CardFactory.GetUnitCards(game.PlayerTwo.BattleFieldRow.FirstOrDefault(x => x.Row == Row.CLOSE).Cards)
                .Where(x => x.AllowDamageAndDecoy()).ToList();

            cardsPlayerTwo.ForEach(card => card.SetWheaterStrengthValue());
        }
    }
}
