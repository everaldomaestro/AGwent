#nullable disable
using AGwent.Models.Cards.Base;
using AGwent.Models.Game;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.Abilities
{
    public sealed class TorrentialRain : Ability
    {
        public TorrentialRain()
        {
            Type = TypeCard.SPECIAL;
            Name = "Torrential Rain";
            Description = "Place face up on the battlefield. Sets strength of all siege combat units to 1 for both players.";
        }

        public override void RunAbility(Gwent game, PlayerNumber player, Card card, Row? row = null)
        {
            var cardsPlayerOne = CardFactory.GetUnitCards(game.PlayerOne.BattleFieldRow.FirstOrDefault(x => x.Row == Row.SIEGE).Cards)
                .Where(x => x.AllowDamageAndDecoy()).ToList();

            cardsPlayerOne.ForEach(card => card.SetWheaterStrengthValue());

            var cardsPlayerTwo = CardFactory.GetUnitCards(game.PlayerTwo.BattleFieldRow.FirstOrDefault(x => x.Row == Row.SIEGE).Cards)
                .Where(x => x.AllowDamageAndDecoy()).ToList();

            cardsPlayerTwo.ForEach(card => card.SetWheaterStrengthValue());
        }
    }
}
