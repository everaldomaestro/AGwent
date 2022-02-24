#nullable disable
using AGwent.Models.Cards.Base;
using AGwent.Models.Game;
using AGwent.Models.Others;
using System.Diagnostics;

namespace AGwent.Models.Cards
{
    public class UnitCard : Card
    {
        public int StrengthValueOriginal { get; protected set; }
        public int StrengthValue { get; protected set; }
        public Row[] Ranges { get; protected set; }
        public bool Hero { get; protected set; }
        public override TypeCard Type { get; protected set; } = TypeCard.UNIT;

        public override void PlayCard(Gwent game, Row? row, PlayerNumber player)
        {
            game.GetPlayer(player).PlayCard(this, row.GetValueOrDefault());
            //game.GetPlayer(player).Hand.RemoveCard(this);
            //game.GetPlayer(player).BattleFieldRow.FirstOrDefault(x => x.Row == row).AddCard(this);

            this.Ability?.RunAbility(game, player, this, row);
        }

        public virtual Row[] SelectCard()
        {
            return this.Ranges;
        }

        public bool AllowDamageAndDecoy()
        {
            return !Hero;
        }

        public void SetWheaterStrengthValue()
        {
            if (AllowDamageAndDecoy())
                StrengthValue = 1;

            Debug.WriteLine($"{Name} - {nameof(StrengthValueOriginal)}: {StrengthValueOriginal}, {nameof(StrengthValue)}: {StrengthValue}");
        }

        public void RemoveWheaterStrengthValue()
        {
            if (AllowDamageAndDecoy())
                StrengthValue = StrengthValueOriginal;

            Debug.WriteLine($"{Name} - {nameof(StrengthValueOriginal)}: {StrengthValueOriginal}, {nameof(StrengthValue)}: {StrengthValue}");
        }        
    }
}
