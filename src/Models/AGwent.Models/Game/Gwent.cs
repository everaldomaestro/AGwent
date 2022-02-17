﻿namespace AGwent.Models.Game
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
    }
}