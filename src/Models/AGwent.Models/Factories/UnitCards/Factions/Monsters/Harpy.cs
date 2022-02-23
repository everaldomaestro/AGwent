#nullable disable
using AGwent.Models.Cards;
using AGwent.Models.Game;
using AGwent.Models.Others;

namespace AGwent.Models.Factories.UnitCards.Factions.Monsters
{
    public class Harpy : UnitCard
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
            if (player == PlayerNumber.ONE)
            {
                game.PlayerOne.Hand.RemoveCard(this);
                game.PlayerOne.BattleFieldRow.FirstOrDefault(x => x.Row == row).AddCard(this);
            }
            else
            {
                game.PlayerTwo.Hand.RemoveCard(this);
                game.PlayerTwo.BattleFieldRow.FirstOrDefault(x => x.Row == row).AddCard(this);
            }
        }
    }
}
