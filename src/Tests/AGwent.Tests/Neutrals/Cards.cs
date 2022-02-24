#nullable disable
using AGwent.Models.Factories.Abilities;
using AGwent.Models.Factories.UnitCards.Factions.NorthernRealms;
using AGwent.Models.Factories.UnitCards.Neutrals;
using AGwent.Models.Game;
using AGwent.Models.Others;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AGwent.Tests.Neutrals
{
    public class Cards
    {
        [Fact]
        public void Villentretenmerth()
        {
            var villentretenmerthP1 = new Villentretenmerth();
            var vesemirP1 = new Vesemir();
            var zoltanChivayP1 = new ZoltanChivay();

            var keiraMetzP2 = new KeiraMetz();
            var vesP2 = new Ves();
            var geraltP2 = new GeraltOfRivia();

            var game = new Gwent();

            Assert.True(villentretenmerthP1.Name.Equals("Villentretenmerth"));
            //Assert.True(villentretenmerth.Description.Equals("There are many species of harpy, and all are kleptomaniacs."));
            Assert.True(villentretenmerthP1.StrengthValueOriginal == 7);
            Assert.True(villentretenmerthP1.StrengthValue == villentretenmerthP1.StrengthValueOriginal);
            Assert.True(villentretenmerthP1.Hero == false);
            Assert.True(villentretenmerthP1.Category == Category.NEUTRAL);
            Assert.True(villentretenmerthP1.Ability.GetType() == typeof(Scorch));

            game.PlayerOne.Hand.AddCard(villentretenmerthP1);
            Assert.True(game.PlayerOne.Hand.Cards.Contains(villentretenmerthP1));
            Assert.True(villentretenmerthP1.StatusCard == StatusCard.HAND);

            game.PlayerOne.Hand.AddCard(vesemirP1);
            Assert.True(game.PlayerOne.Hand.Cards.Contains(vesemirP1));
            Assert.True(vesemirP1.StatusCard == StatusCard.HAND);

            game.PlayerOne.Hand.AddCard(zoltanChivayP1);
            Assert.True(game.PlayerOne.Hand.Cards.Contains(zoltanChivayP1));
            Assert.True(zoltanChivayP1.StatusCard == StatusCard.HAND);

            game.PlayerTwo.Hand.AddCard(keiraMetzP2);
            Assert.True(game.PlayerTwo.Hand.Cards.Contains(keiraMetzP2));
            Assert.True(keiraMetzP2.StatusCard == StatusCard.HAND);

            game.PlayerTwo.Hand.AddCard(vesP2);
            Assert.True(game.PlayerTwo.Hand.Cards.Contains(vesP2));
            Assert.True(vesP2.StatusCard == StatusCard.HAND);

            game.PlayerTwo.Hand.AddCard(geraltP2);
            Assert.True(game.PlayerTwo.Hand.Cards.Contains(geraltP2));
            Assert.True(geraltP2.StatusCard == StatusCard.HAND);

            vesP2.PlayCard(game, vesP2.Ranges[0], PlayerNumber.TWO);
            Assert.True(game.PlayerTwo.BattleFieldRow.FirstOrDefault(x => x.Row == vesP2.Ranges[0]).Cards.Contains(vesP2));
            Assert.True(vesP2.StatusCard == StatusCard.BATTLE);

            vesemirP1.PlayCard(game, vesemirP1.Ranges[0], PlayerNumber.ONE);
            Assert.True(game.PlayerOne.BattleFieldRow.FirstOrDefault(x=>x.Row == vesemirP1.Ranges[0]).Cards.Contains(vesemirP1));
            Assert.True(vesemirP1.StatusCard == StatusCard.BATTLE);

            keiraMetzP2.PlayCard(game, keiraMetzP2.Ranges[0], PlayerNumber.TWO);
            Assert.True(game.PlayerTwo.BattleFieldRow.FirstOrDefault(x => x.Row == keiraMetzP2.Ranges[0]).Cards.Contains(keiraMetzP2));
            Assert.True(keiraMetzP2.StatusCard == StatusCard.BATTLE);

            zoltanChivayP1.PlayCard(game, zoltanChivayP1.Ranges[0], PlayerNumber.ONE);
            Assert.True(game.PlayerOne.BattleFieldRow.FirstOrDefault(x => x.Row == zoltanChivayP1.Ranges[0]).Cards.Contains(zoltanChivayP1));
            Assert.True(zoltanChivayP1.StatusCard == StatusCard.BATTLE);

            geraltP2.PlayCard(game, geraltP2.Ranges[0], PlayerNumber.TWO);
            Assert.True(game.PlayerTwo.BattleFieldRow.FirstOrDefault(x => x.Row == geraltP2.Ranges[0]).Cards.Contains(geraltP2));
            Assert.True(geraltP2.StatusCard == StatusCard.BATTLE);

            var areasP1 = villentretenmerthP1.SelectCard();

            Assert.True(areasP1.Length == 1);

            foreach (var area in areasP1)
                Assert.True(area == Row.CLOSE);

            villentretenmerthP1.PlayCard(game, Row.CLOSE, PlayerNumber.ONE);

            Assert.True(game.PlayerOne.BattleFieldRow.FirstOrDefault(x => x.Row == villentretenmerthP1.Ranges[0]).Cards.Contains(villentretenmerthP1));
            Assert.True(villentretenmerthP1.StatusCard == StatusCard.BATTLE);
            Assert.False(game.PlayerOne.Hand.Cards.Contains(villentretenmerthP1));

            Assert.True(game.PlayerOne.BattleFieldRow.FirstOrDefault(x => x.Row == vesemirP1.Ranges[0]).Cards.Contains(vesemirP1));
            Assert.True(vesemirP1.StatusCard == StatusCard.BATTLE);
            Assert.False(game.PlayerOne.Hand.Cards.Contains(vesemirP1));

            Assert.True(game.PlayerOne.BattleFieldRow.FirstOrDefault(x => x.Row == zoltanChivayP1.Ranges[0]).Cards.Contains(zoltanChivayP1));
            Assert.True(zoltanChivayP1.StatusCard == StatusCard.BATTLE);
            Assert.False(game.PlayerOne.Hand.Cards.Contains(zoltanChivayP1));

            Assert.True(game.PlayerTwo.BattleFieldRow.FirstOrDefault(x => x.Row == geraltP2.Ranges[0]).Cards.Contains(geraltP2));
            Assert.True(geraltP2.StatusCard == StatusCard.BATTLE);
            Assert.False(game.PlayerTwo.Hand.Cards.Contains(geraltP2));
            Assert.False(game.PlayerTwo.Discard.Cards.Contains(geraltP2));

            Assert.True(vesP2.StatusCard == StatusCard.DISCARD);
            Assert.True(game.PlayerTwo.Discard.Cards.Contains(vesP2));
            Assert.False(game.PlayerTwo.BattleFieldRow.FirstOrDefault(x => x.Row == vesP2.Ranges[0]).Cards.Contains(vesP2));
            Assert.False(game.PlayerTwo.Hand.Cards.Contains(vesP2));

            Assert.False(keiraMetzP2.StatusCard == StatusCard.DISCARD);
            Assert.True(keiraMetzP2.StatusCard == StatusCard.BATTLE);
            Assert.True(game.PlayerTwo.BattleFieldRow.FirstOrDefault(x => x.Row == keiraMetzP2.Ranges[0]).Cards.Contains(keiraMetzP2));
            Assert.False(game.PlayerTwo.Hand.Cards.Contains(keiraMetzP2));
        }
    }
}
