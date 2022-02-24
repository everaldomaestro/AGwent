using AGwent.Models.Others;

namespace AGwent.Models.Game
{
    public class Gwent
    {
        public Gwent()
        {
            BattleFieldWeather = new BattleFieldWeather();
            PlayerOne = new BattleField(BattleFieldWeather);
            PlayerTwo = new BattleField(BattleFieldWeather);
        }

        public BattleFieldWeather BattleFieldWeather { get; private set; }
        public BattleField PlayerOne { get; private set; }
        public BattleField PlayerTwo { get; private set; }

        public BattleField GetPlayer(PlayerNumber player) => player == PlayerNumber.ONE ? PlayerOne : PlayerTwo;
        public BattleField GetAnotherPlayer(PlayerNumber player) => player == PlayerNumber.ONE ? PlayerTwo : PlayerOne;
    }
}