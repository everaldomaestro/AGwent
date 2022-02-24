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

        [Fact]
        public void Ghoul()
        {
            var ghoul01 = new Ghoul();
            var ghoul02 = new Ghoul();
            var ghoul03 = new Ghoul();
            var game = new Gwent();

            Assert.True(ghoul01.Name.Equals("Ghoul"));
            Assert.True(ghoul01.Description.Equals("If ghouls are part of the Circle of Life... then it's a damn vicious circle."));
            Assert.True(ghoul01.StrengthValueOriginal == 1);
            Assert.True(ghoul01.StrengthValue == ghoul01.StrengthValueOriginal);
            Assert.True(ghoul01.Hero == false);
            Assert.True(ghoul01.Category == Category.FACTION);
            Assert.True(ghoul01.Ability.GetType() == typeof(Muster));

            game.PlayerOne.Hand.AddCard(ghoul01);
            Assert.True(game.PlayerOne.Hand.Cards.Contains(ghoul01));
            Assert.True(ghoul01.StatusCard == StatusCard.HAND);

            game.PlayerOne.Deck.AddCard(ghoul02);
            Assert.True(game.PlayerOne.Deck.Cards.Contains(ghoul02));
            Assert.True(ghoul02.StatusCard == StatusCard.DECK);

            game.PlayerOne.Discard.AddCard(ghoul03);
            Assert.True(game.PlayerOne.Discard.Cards.Contains(ghoul03));
            Assert.True(ghoul03.StatusCard == StatusCard.DISCARD);

            var areas = ghoul01.SelectCard();

            Assert.True(areas.Length == 1);

            foreach (var area in areas)
                Assert.True(area == Row.CLOSE);

            ghoul01.PlayCard(game, Row.CLOSE, PlayerNumber.ONE);

            Assert.True(game.PlayerOne.BattleFieldRow.FirstOrDefault(x => x.Row == Row.CLOSE).Cards.Contains(ghoul01));
            Assert.True(ghoul01.StatusCard == StatusCard.BATTLE);
            Assert.False(game.PlayerOne.Hand.Cards.Contains(ghoul01));

            Assert.True(game.PlayerOne.BattleFieldRow.FirstOrDefault(x => x.Row == Row.CLOSE).Cards.Contains(ghoul02));
            Assert.True(ghoul02.StatusCard == StatusCard.BATTLE);
            Assert.False(game.PlayerOne.Deck.Cards.Contains(ghoul02));

            Assert.True(game.PlayerOne.Discard.Cards.Contains(ghoul03));
            Assert.True(ghoul03.StatusCard == StatusCard.DISCARD);
            Assert.True(game.PlayerOne.Discard.Cards.Contains(ghoul03));
        }

        [Fact]
        public void Arachas()
        {
            var arachas01 = new Arachas();
            var arachas02 = new Arachas();
            var arachas03 = new Arachas();
            var arachas04 = new ArachasBehemoth();
            var game = new Gwent();

            Assert.True(arachas01.Name.Equals("Arachas"));
            Assert.True(arachas01.Description.Equals("Ugly - nature's way of saying 'Stay the fuck away."));
            Assert.True(arachas01.StrengthValueOriginal == 4);
            Assert.True(arachas01.StrengthValue == arachas01.StrengthValueOriginal);
            Assert.True(arachas01.Hero == false);
            Assert.True(arachas01.Category == Category.FACTION);
            Assert.True(arachas01.Ability.GetType() == typeof(Muster));

            Assert.True(arachas04.Name.Equals("Arachas Behemoth"));
            Assert.True(arachas04.Description.Equals("Like a cross between a crab, a spider... and a ploughin' mountain."));
            Assert.True(arachas04.StrengthValueOriginal == 6);
            Assert.True(arachas04.StrengthValue == arachas04.StrengthValueOriginal);
            Assert.True(arachas04.Hero == false);
            Assert.True(arachas04.Category == Category.FACTION);
            Assert.True(arachas04.Ability.GetType() == typeof(Muster));

            game.PlayerOne.Hand.AddCard(arachas01);
            Assert.True(game.PlayerOne.Hand.Cards.Contains(arachas01));
            Assert.True(arachas01.StatusCard == StatusCard.HAND);

            game.PlayerOne.Hand.AddCard(arachas04);
            Assert.True(game.PlayerOne.Hand.Cards.Contains(arachas04));
            Assert.True(arachas04.StatusCard == StatusCard.HAND);

            game.PlayerOne.Deck.AddCard(arachas02);
            Assert.True(game.PlayerOne.Deck.Cards.Contains(arachas02));
            Assert.True(arachas02.StatusCard == StatusCard.DECK);

            game.PlayerOne.Discard.AddCard(arachas03);
            Assert.True(game.PlayerOne.Discard.Cards.Contains(arachas03));
            Assert.True(arachas03.StatusCard == StatusCard.DISCARD);

            var areas = arachas01.SelectCard();

            Assert.True(areas.Length == 1);

            foreach (var area in areas)
                Assert.True(area == Row.CLOSE);

            arachas04.PlayCard(game, Row.SIEGE, PlayerNumber.ONE);

            Assert.True(game.PlayerOne.BattleFieldRow.FirstOrDefault(x => x.Row == Row.CLOSE).Cards.Contains(arachas01));
            Assert.True(arachas01.StatusCard == StatusCard.BATTLE);
            Assert.False(game.PlayerOne.Hand.Cards.Contains(arachas01));

            Assert.True(game.PlayerOne.BattleFieldRow.FirstOrDefault(x => x.Row == Row.SIEGE).Cards.Contains(arachas04));
            Assert.True(arachas04.StatusCard == StatusCard.BATTLE);
            Assert.False(game.PlayerOne.Hand.Cards.Contains(arachas04));

            Assert.True(game.PlayerOne.BattleFieldRow.FirstOrDefault(x => x.Row == Row.CLOSE).Cards.Contains(arachas02));
            Assert.True(arachas02.StatusCard == StatusCard.BATTLE);
            Assert.False(game.PlayerOne.Deck.Cards.Contains(arachas02));

            Assert.True(game.PlayerOne.Discard.Cards.Contains(arachas03));
            Assert.True(arachas03.StatusCard == StatusCard.DISCARD);
            Assert.True(game.PlayerOne.Discard.Cards.Contains(arachas03));
        }

        [Fact]
        public void Nekker()
        {
            var nekker01 = new Nekker();
            var nekker02 = new Nekker();
            var nekker03 = new Nekker();
            var game = new Gwent();

            Assert.True(nekker01.Name.Equals("Nekker"));
            Assert.True(nekker01.Description.Equals("Damn things are almost cute, if you ignore the whole vicious killer aspect."));
            Assert.True(nekker01.StrengthValueOriginal == 2);
            Assert.True(nekker01.StrengthValue == nekker01.StrengthValueOriginal);
            Assert.True(nekker01.Hero == false);
            Assert.True(nekker01.Category == Category.FACTION);
            Assert.True(nekker01.Ability.GetType() == typeof(Muster));

            game.PlayerOne.Hand.AddCard(nekker01);
            Assert.True(game.PlayerOne.Hand.Cards.Contains(nekker01));
            Assert.True(nekker01.StatusCard == StatusCard.HAND);

            game.PlayerOne.Deck.AddCard(nekker02);
            Assert.True(game.PlayerOne.Deck.Cards.Contains(nekker02));
            Assert.True(nekker02.StatusCard == StatusCard.DECK);

            game.PlayerOne.Discard.AddCard(nekker03);
            Assert.True(game.PlayerOne.Discard.Cards.Contains(nekker03));
            Assert.True(nekker03.StatusCard == StatusCard.DISCARD);

            var areas = nekker01.SelectCard();

            Assert.True(areas.Length == 1);

            foreach (var area in areas)
                Assert.True(area == Row.CLOSE);

            nekker01.PlayCard(game, Row.CLOSE, PlayerNumber.ONE);

            Assert.True(game.PlayerOne.BattleFieldRow.FirstOrDefault(x => x.Row == Row.CLOSE).Cards.Contains(nekker01));
            Assert.True(nekker01.StatusCard == StatusCard.BATTLE);
            Assert.False(game.PlayerOne.Hand.Cards.Contains(nekker01));

            Assert.True(game.PlayerOne.BattleFieldRow.FirstOrDefault(x => x.Row == Row.CLOSE).Cards.Contains(nekker02));
            Assert.True(nekker02.StatusCard == StatusCard.BATTLE);
            Assert.False(game.PlayerOne.Deck.Cards.Contains(nekker02));

            Assert.True(game.PlayerOne.Discard.Cards.Contains(nekker03));
            Assert.True(nekker03.StatusCard == StatusCard.DISCARD);
            Assert.True(game.PlayerOne.Discard.Cards.Contains(nekker03));
        }

        [Fact]
        public void CelaenoHarpy()
        {
            var celaenoharpyP1 = new CelaenoHarpy();
            var celaenoharpyP2 = new CelaenoHarpy();
            var game = new Gwent();

            Assert.True(celaenoharpyP1.Name.Equals("Celaeno Harpy"));
            Assert.True(celaenoharpyP1.Description.Equals("Common harpies feed on carrion. Celaeno harpies... they feed on dreams."));
            Assert.True(celaenoharpyP1.StrengthValueOriginal == 2);
            Assert.True(celaenoharpyP1.StrengthValue == celaenoharpyP1.StrengthValueOriginal);
            Assert.True(celaenoharpyP1.Hero == false);
            Assert.True(celaenoharpyP1.Category == Category.FACTION);
            Assert.True(celaenoharpyP1.Ability.GetType() == typeof(Agile));

            game.PlayerOne.Hand.AddCard(celaenoharpyP1);
            Assert.True(game.PlayerOne.Hand.Cards.Contains(celaenoharpyP1));
            Assert.True(celaenoharpyP1.StatusCard == StatusCard.HAND);

            game.PlayerTwo.Hand.AddCard(celaenoharpyP2);
            Assert.True(game.PlayerTwo.Hand.Cards.Contains(celaenoharpyP2));
            Assert.True(celaenoharpyP2.StatusCard == StatusCard.HAND);

            var areasP1 = celaenoharpyP1.SelectCard();

            Assert.True(areasP1.Length == 2);

            foreach (var area in areasP1)
                Assert.True(area == Row.CLOSE || area == Row.RANGED);

            celaenoharpyP1.PlayCard(game, Row.CLOSE, PlayerNumber.ONE);

            Assert.True(game.PlayerOne.BattleFieldRow.FirstOrDefault(x => x.Row == Row.CLOSE).Cards.Contains(celaenoharpyP1));
            Assert.True(celaenoharpyP1.StatusCard == StatusCard.BATTLE);
            Assert.False(game.PlayerOne.Hand.Cards.Contains(celaenoharpyP1));


            var areasP2 = celaenoharpyP2.SelectCard();

            Assert.True(areasP2.Length == 2);

            foreach (var area in areasP2)
                Assert.True(area == Row.CLOSE || area == Row.RANGED);

            celaenoharpyP2.PlayCard(game, Row.RANGED, PlayerNumber.TWO);

            Assert.True(game.PlayerTwo.BattleFieldRow.FirstOrDefault(x => x.Row == Row.RANGED).Cards.Contains(celaenoharpyP2));
            Assert.True(celaenoharpyP2.StatusCard == StatusCard.BATTLE);
            Assert.False(game.PlayerTwo.Hand.Cards.Contains(celaenoharpyP2));
        }
    }
}
