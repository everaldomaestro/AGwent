#nullable disable
using AGwent.Models.Cards.Base;
using AGwent.Models.Factories.Abilities;
using AGwent.Models.Game;
using AGwent.Models.Others;

namespace AGwent.Models.Cards
{
    public class SpecialCard : Card
    {
        public override TypeCard Type { get; protected set; } = TypeCard.SPECIAL;

        public override void PlayCard(Gwent game, Row? row, PlayerNumber player)
        {
            if (this.Ability.GetType() == typeof(BitingFrost) || this.Ability.GetType() == typeof(ClearWeather))
            {
                game.BattleFieldWeather.AddSpecialCard(this);
            }
            else
            {
                if (player == PlayerNumber.ONE)
                {
                    game.PlayerOne.Hand.RemoveCard(this);
                    if(row.HasValue)
                        game.PlayerOne.BattleFieldRow.FirstOrDefault(x => x.Row == row).AddCard(this);
                }
                else
                {
                    game.PlayerTwo.Hand.RemoveCard(this);
                    if (row.HasValue)
                        game.PlayerTwo.BattleFieldRow.FirstOrDefault(x => x.Row == row).AddCard(this);
                }
            }

            this.Ability.RunAbility(game, row, player);
        }
    }
}
