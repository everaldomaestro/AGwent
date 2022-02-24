using AGwent.Models.Cards.Base;
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

        public override void RunAbility(Gwent game, PlayerNumber player, Card card, Row? row = null)
        {
            var cards = CardFactory.GetUnitCards(game.GetPlayer(player).Discard.Cards.ToList()).Where(x => x.AllowDamageAndDecoy());

            //Todo: callback pra saber qual carta jogar            
        }
    }
}
