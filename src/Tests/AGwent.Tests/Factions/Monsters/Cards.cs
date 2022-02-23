#nullable disable
using AGwent.Models.Factories.Abilities;
using AGwent.Models.Factories.UnitCards.Factions.Monsters;
using AGwent.Models.Game;
using AGwent.Models.Others;
using System.Linq;
using Xunit;

namespace AGwent.Tests.Factions.Monsters
{
    public class Cards
    {
        [Fact]
        public void Harpy()
        {
            var harpyP1 = new Harpy();
            var harpyP2 = new Harpy();
            var game = new Gwent();

            Assert.True(harpyP1.Name.Equals("Harpy"));
            Assert.True(harpyP1.Description.Equals("There are many species of harpy, and all are kleptomaniacs."));
            Assert.True(harpyP1.StrengthValueOriginal == 2);
            Assert.True(harpyP1.StrengthValue == harpyP1.StrengthValueOriginal);
            Assert.True(harpyP1.Hero == false);
            Assert.True(harpyP1.Category == Category.FACTION);
            Assert.True(harpyP1.Ability.GetType() == typeof(Agile));

            game.PlayerOne.Hand.AddCard(harpyP1);
            Assert.True(game.PlayerOne.Hand.Cards.Contains(harpyP1));
            Assert.True(harpyP1.StatusCard == StatusCard.HAND);

            game.PlayerTwo.Hand.AddCard(harpyP2);
            Assert.True(game.PlayerTwo.Hand.Cards.Contains(harpyP2));
            Assert.True(harpyP2.StatusCard == StatusCard.HAND);

            var areasP1 = harpyP1.SelectCard();

            Assert.True(areasP1.Length == 2);

            foreach (var area in areasP1)
                Assert.True(area == Row.CLOSE || area == Row.RANGED);

            harpyP1.PlayCard(game, Row.CLOSE, PlayerNumber.ONE);

            Assert.True(game.PlayerOne.BattleFieldRow.FirstOrDefault(x => x.Row == Row.CLOSE).Cards.Contains(harpyP1));
            Assert.True(harpyP1.StatusCard == StatusCard.BATTLE);
            Assert.False(game.PlayerOne.Hand.Cards.Contains(harpyP1));


            var areasP2 = harpyP2.SelectCard();

            Assert.True(areasP2.Length == 2);

            foreach (var area in areasP2)
                Assert.True(area == Row.CLOSE || area == Row.RANGED);

            harpyP2.PlayCard(game, Row.RANGED, PlayerNumber.TWO);

            Assert.True(game.PlayerTwo.BattleFieldRow.FirstOrDefault(x => x.Row == Row.RANGED).Cards.Contains(harpyP2));
            Assert.True(harpyP2.StatusCard == StatusCard.BATTLE);
            Assert.False(game.PlayerTwo.Hand.Cards.Contains(harpyP2));
        }

        [Fact]
        public void Foglet()
        {
            var foglet = new Foglet();
            var game = new Gwent();

            Assert.True(foglet.Name.Equals("Foglet"));
            Assert.True(foglet.Description.Equals("Fog creeps on little cat feet. Foglets creep over the bodies of their victims."));
            Assert.True(foglet.StrengthValueOriginal == 2);
            Assert.True(foglet.StrengthValue == foglet.StrengthValueOriginal);
            Assert.True(foglet.Hero == false);
            Assert.True(foglet.Category == Category.FACTION);
            Assert.Null(foglet.Ability);

            game.PlayerOne.Hand.AddCard(foglet);
            Assert.True(game.PlayerOne.Hand.Cards.Contains(foglet));
            Assert.True(foglet.StatusCard == StatusCard.HAND);

            var areas = foglet.SelectCard();

            Assert.True(areas.Length == 1);

            foreach (var area in areas)
                Assert.True(area == Row.CLOSE);

            foglet.PlayCard(game, Row.CLOSE, PlayerNumber.ONE);

            Assert.True(game.PlayerOne.BattleFieldRow.FirstOrDefault(x => x.Row == Row.CLOSE).Cards.Contains(foglet));
            Assert.True(foglet.StatusCard == StatusCard.BATTLE);
            Assert.False(game.PlayerOne.Hand.Cards.Contains(foglet));
        }
    }
}
