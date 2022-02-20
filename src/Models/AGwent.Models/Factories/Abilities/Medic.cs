using AGwent.Models.Game;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.Abilities
{
    public sealed class Medic : Ability
    {
        public Medic()
        {
            Type = TypeCard.SPECIAL;
            Name = "Medic";
            Description = "Choose one card from your discard pile and play it instantly (no Heroes or Special Cards).";
        }

        public override void RunAbility(Gwent game, Row? row, PlayerNumber player)
        {
            if(player == PlayerNumber.ONE)
            {
                var cards = CardFactory.GetUnitCards(game.PlayerOne.Discard.Cards.ToList()).Where(x => x.AllowDamageAndDecoy());
                //Todo: callback pra saber qual carta jogar
            }
            else
            {
                var cards = CardFactory.GetUnitCards(game.PlayerTwo.Discard.Cards.ToList()).Where(x => x.AllowDamageAndDecoy());
                //Todo: callback pra saber qual carta jogar
            }
        }
    }
}
