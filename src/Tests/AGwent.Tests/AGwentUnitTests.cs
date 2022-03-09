#nullable disable
using AGwent.Models.Cards;
using AGwent.Models.Cards.Base;
using AGwent.Models.Factories;
using AGwent.Models.Factories.SpecialCards;
using AGwent.Models.Factories.UnitCards.Factions.NorthernRealms;
using AGwent.Models.Factories.UnitCards.Neutrals;
using AGwent.Models.Game;
using AGwent.Models.Others;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Xunit;

namespace AGwent.Tests
{
    public class AGwentUnitTests
    {
        [Fact]
        public void Test1()
        {
            var geraltOfRiviaP1 = new GeraltOfRivia();
            var vesemirP1 = new Vesemir();
            var keiraMetzP1 = new KeiraMetz();
            var clearWeatherP1 = new ClearWeather();
            var bitingFrostP2 = new BitingFrost();
            var scorchP2 = new Scorch();

            var gwent = new Gwent();
            gwent.PlayerOne.Deck.AddCard(geraltOfRiviaP1);
            gwent.PlayerOne.Deck.AddCard(vesemirP1);
            gwent.PlayerOne.Deck.AddCard(keiraMetzP1);
            gwent.PlayerOne.Deck.AddCard(clearWeatherP1);

            //gwent.PlayerTwo.Deck.AddCard(geraltOfRiviaP1);
            //gwent.PlayerTwo.Deck.AddCard(vesemirP1);
            //gwent.PlayerTwo.Deck.AddCard(keiraMetzP1);
            gwent.PlayerTwo.Deck.AddCard(bitingFrostP2);
            gwent.PlayerTwo.Deck.AddCard(scorchP2);

            gwent.PlayerOne.Deck.RemoveCard(geraltOfRiviaP1);
            gwent.PlayerOne.Deck.RemoveCard(vesemirP1);
            gwent.PlayerOne.Deck.RemoveCard(keiraMetzP1);
            gwent.PlayerOne.Deck.RemoveCard(clearWeatherP1);

            //gwent.PlayerTwo.Deck.RemoveCard(geraltOfRiviaP1);
            //gwent.PlayerTwo.Deck.RemoveCard(vesemirP1);
            //gwent.PlayerTwo.Deck.RemoveCard(keiraMetzP1);
            gwent.PlayerTwo.Deck.RemoveCard(bitingFrostP2);
            gwent.PlayerTwo.Deck.RemoveCard(scorchP2);

            gwent.PlayerOne.Hand.AddCard(geraltOfRiviaP1);
            gwent.PlayerOne.Hand.AddCard(vesemirP1);
            gwent.PlayerOne.Hand.AddCard(keiraMetzP1);
            gwent.PlayerOne.Hand.AddCard(clearWeatherP1);

            //gwent.PlayerTwo.Hand.AddCard(geraltOfRiviaP1);
            //gwent.PlayerTwo.Hand.AddCard(vesemirP1);
            //gwent.PlayerTwo.Hand.AddCard(keiraMetzP1);
            gwent.PlayerTwo.Hand.AddCard(bitingFrostP2);
            gwent.PlayerTwo.Hand.AddCard(scorchP2);

            geraltOfRiviaP1.PlayCard(gwent, geraltOfRiviaP1.Ranges.FirstOrDefault(), PlayerNumber.ONE);
            //geraltOfRiviaP2.PlayCard(gwent, gwent.PlayerTwo.BattleFieldRow.FirstOrDefault(x => x.Row == geraltOfRiviaP2.Ranges.FirstOrDefault()), PlayerNumber.TWO);

            vesemirP1.PlayCard(gwent, vesemirP1.Ranges.FirstOrDefault(), PlayerNumber.ONE);

            keiraMetzP1.PlayCard(gwent, keiraMetzP1.Ranges.FirstOrDefault(), PlayerNumber.ONE);
            bitingFrostP2.PlayCard(gwent, null, PlayerNumber.TWO);

            Assert.Equal(keiraMetzP1.StrengthValueOriginal, keiraMetzP1.StrengthValue);
            Assert.Equal(1, vesemirP1.StrengthValue);

            clearWeatherP1.PlayCard(gwent, null, PlayerNumber.ONE);

            Assert.Equal(StatusCard.BATTLE, keiraMetzP1.StatusCard);
            Assert.Equal(keiraMetzP1.StrengthValueOriginal, keiraMetzP1.StrengthValue);
            Assert.True(gwent.PlayerOne.BattleFieldRow.FirstOrDefault(x => x.Row == Row.RANGED).Cards.Contains(keiraMetzP1));

            Assert.Equal(StatusCard.BATTLE, vesemirP1.StatusCard);
            Assert.Equal(vesemirP1.StrengthValueOriginal, vesemirP1.StrengthValue);
            Assert.True(gwent.PlayerOne.BattleFieldRow.FirstOrDefault(x => x.Row == Row.CLOSE).Cards.Contains(vesemirP1));

            Assert.Null(bitingFrostP2.StatusCard);
            Assert.False(gwent.PlayerTwo.Discard.Cards.Contains(bitingFrostP2));

            Assert.Null(clearWeatherP1.StatusCard);
            Assert.False(gwent.PlayerOne.Discard.Cards.Contains(clearWeatherP1));

            scorchP2.PlayCard(gwent, null, PlayerNumber.TWO);
            Assert.True(gwent.PlayerOne.Discard.Cards.Contains(vesemirP1));
        }

        [Fact]
        public void Test2()
        {
            //var unitCards =
            //    typeof(Card)
            //    .Assembly.GetTypes()
            //    .Where(t => t.IsSubclassOf(typeof(Card)) && !t.IsAbstract)
            //    .Select(t => (Card)Activator.CreateInstance(t))
            //    .ToList();

            var listCards = CardFactory.GenerateCards();

            DefaultContractResolver contractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy()
            };

            var serializable = JsonConvert.SerializeObject(listCards, new JsonSerializerSettings
            {
                ContractResolver = contractResolver,
                Formatting = Formatting.Indented
            });

            var stopwatch1 = new Stopwatch();

            //Assert.Equal(unitCards.Count, CardFactory.GetUnitCards(unitCards).Count + CardFactory.GetSpecialCards(unitCards).Count);
            //Assert.Equal(unitCards.Count, (CardFactory.GetCards<UnitCard>(unitCards).Count + 1) + (CardFactory.GetCards<SpecialCard>(unitCards).Count + 1));

            //var stopwatch1 = new Stopwatch();
            //stopwatch1.Start();
            //for(int i = 0; i < 10; i++)
            //    CardFactory.GetUnitCards(unitCards);
            //stopwatch1.Stop();
            //var t1 = stopwatch1.Elapsed;

            //var stopwatch2 = new Stopwatch();
            //stopwatch2.Start();
            //for (int i = 0; i < 10; i++)
            //    CardFactory.GetCards<UnitCard>(unitCards);
            //stopwatch2.Stop();
            //var t2 = stopwatch2.Elapsed;

            //Assert.Equal(t1, t2);
        }
    }
}