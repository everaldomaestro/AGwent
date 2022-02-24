using AGwent.Models.Cards.Base;
using AGwent.Models.Game;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.Abilities
{
    public sealed class ClearWeather : Ability
    {
        public ClearWeather()
        {
            Type = TypeCard.SPECIAL;
            Name = "Clear Wheater";
            Description = "Discard after playing. Discard all Weather Cards currently on the battlefield.Their effects are cancelled.";
        }

        public override void RunAbility(Gwent game,PlayerNumber player, Card card, Row? row = null)
        {
            var weathers = game.BattleFieldWeather.Weaters.ToList();
            game.BattleFieldWeather.RemoveAllSpecialCards();

            var cardsPlayOne = CardFactory.GetUnitCards(game.PlayerOne.BattleFieldRow.SelectMany(x => x.Cards).ToList())
                .Where(w => w.AllowDamageAndDecoy()).ToList();
            cardsPlayOne.ForEach(x => x.RemoveWheaterStrengthValue());

            var cardsPlayTwo = CardFactory.GetUnitCards(game.PlayerTwo.BattleFieldRow.SelectMany(x => x.Cards).ToList())
                .Where(w => w.AllowDamageAndDecoy()).ToList();
            cardsPlayTwo.ForEach(x => x.RemoveWheaterStrengthValue());
        }
    }
}
