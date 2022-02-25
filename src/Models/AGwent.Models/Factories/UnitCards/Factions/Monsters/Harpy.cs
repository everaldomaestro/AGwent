#nullable disable
using AGwent.Models.Cards;
using AGwent.Models.Game;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Factions.Monsters
{
    public sealed class Harpy : UnitCard
    {
        public Harpy()
        {
            Name = "Harpy";
            Description = "There are many species of harpy, and all are kleptomaniacs.";
            StrengthValueOriginal = 2;
            StrengthValue = StrengthValueOriginal;
            Ranges = new Row[] { Row.CLOSE, Row.RANGED };
            Hero = false;
            Category = Category.FACTION;
            Ability = new Abilities.Agile();
        }

        public override void PlayCard(Gwent game, Row? row, PlayerNumber player)
        {
            game.GetPlayer(player).Hand.RemoveCard(this);
            game.GetPlayer(player).BattleFieldRow.FirstOrDefault(x => x.Row == row).AddCard(this);
        }
    }
}
