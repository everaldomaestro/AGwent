#nullable disable
using AGwent.Models.Cards.Base;
using AGwent.Models.Game;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.Abilities
{
    public sealed class Scorch : Ability
    {
        public Scorch(TypeCard typeCard)
        {
            Type = typeCard;
            Name = "Scorch";
            Description = "These cards will kill the strongest card(s) on the battlefield, with some affecting all players and some with special conditions.";
        }

        public override void RunAbility(Gwent game, PlayerNumber player, Card card, Row? row)
        {
            if (Type == TypeCard.SPECIAL)
            {
                var maxValuePlayerOne = CardFactory.GetUnitCards(game.PlayerOne.BattleFieldRow.SelectMany(x => x.Cards).ToList())
                    .Where(x => x.AllowDamageAndDecoy()).ToList();
                var maxValuePlayerTwo = CardFactory.GetUnitCards(game.PlayerTwo.BattleFieldRow.SelectMany(x => x.Cards).ToList())
                    .Where(x => x.AllowDamageAndDecoy()).ToList();

                var maxValue =
                    Math.Max(maxValuePlayerOne.Any() ? maxValuePlayerOne.Max(x => x.StrengthValue) : -1,
                             maxValuePlayerTwo.Any() ? maxValuePlayerTwo.Max(x => x.StrengthValue) : -1);

                var cardsPlayerOne = CardFactory.GetUnitCards(game.PlayerOne.BattleFieldRow.SelectMany(x => x.Cards).ToList())
                    .Where(x => x.AllowDamageAndDecoy() && x.StrengthValue == maxValue).ToList();
                var cardsPlayerTwo = CardFactory.GetUnitCards(game.PlayerTwo.BattleFieldRow.SelectMany(x => x.Cards).ToList())
                    .Where(x => x.AllowDamageAndDecoy() && x.StrengthValue == maxValue).ToList();

                foreach (var cardP1 in cardsPlayerOne)
                {
                    game.PlayerOne.BattleFieldRow.ToList().ForEach(x => x.RemoveCard(cardP1));
                    game.PlayerOne.Discard.AddCard(cardP1);
                }

                foreach (var cardP2 in cardsPlayerTwo)
                {
                    game.PlayerTwo.BattleFieldRow.ToList().ForEach(x => x.RemoveCard(cardP2));
                    game.PlayerTwo.Discard.AddCard(cardP2);
                }
            }
            else
            {
                if (player == PlayerNumber.ONE)
                {
                    var maxValuePlayerTwo = CardFactory.GetUnitCards(game.PlayerTwo.BattleFieldRow.FirstOrDefault(x => x.Row == row).Cards)
                        .Where(x => x.AllowDamageAndDecoy()).ToList();
                    var maxValue = maxValuePlayerTwo.Any() ? maxValuePlayerTwo.Max(x => x.StrengthValue) : -1;
                    var cardsPlayerTwo = CardFactory.GetUnitCards(game.PlayerTwo.BattleFieldRow.FirstOrDefault(x => x.Row == row).Cards)
                        .Where(x => x.AllowDamageAndDecoy() && x.StrengthValue == maxValue).ToList();

                    foreach (var cardP2 in cardsPlayerTwo)
                    {
                        game.PlayerTwo.BattleFieldRow.ToList().ForEach(x => x.RemoveCard(cardP2));
                        game.PlayerTwo.Discard.AddCard(cardP2);
                    }
                }
                else
                {
                    var maxValuePlayerOne = CardFactory.GetUnitCards(game.PlayerOne.BattleFieldRow.FirstOrDefault(x => x.Row == row).Cards)
                        .Where(x => x.AllowDamageAndDecoy()).ToList();
                    var maxValue = maxValuePlayerOne.Any() ? maxValuePlayerOne.Max(x => x.StrengthValue) : -1;
                    var cardsPlayerOne = CardFactory.GetUnitCards(game.PlayerOne.BattleFieldRow.FirstOrDefault(x => x.Row == row).Cards)
                        .Where(x => x.AllowDamageAndDecoy() && x.StrengthValue == maxValue).ToList();

                    foreach (var cardP1 in cardsPlayerOne)
                    {
                        game.PlayerOne.BattleFieldRow.ToList().ForEach(x => x.RemoveCard(cardP1));
                        game.PlayerOne.Discard.AddCard(cardP1);
                    }
                }
            }
        }
    }
}
