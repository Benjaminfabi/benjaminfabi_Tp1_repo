
using System;
using System.Collections.Generic;
using LeBataillon.Database.Models;

namespace LeBataillon.Database.MockData
{
    public class GameMockData
    {

        public static List<Game> GetGameTest()
        {
            var _Games = new List<Game>()
            {
                new Game()
                {
                            Id = 1,
                            GameDateTime = new DateTime(2020, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TeamAttackerId = 2,
                            TeamDefendantId = 7
                },
                new Game()
                {
                            Id = 2,
                            GameDateTime = new DateTime(2020, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TeamAttackerId = 3,
                            TeamDefendantId = 4
                },
                new Game()
                {
                            Id = 3,
                            GameDateTime = new DateTime(2020, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TeamAttackerId = 5,
                            TeamDefendantId = 6
                },
                new Game()
                {
                    Id = 4,
                    GameDateTime = new DateTime(2020, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                    TeamAttackerId = 8,
                    TeamDefendantId = 9
                },
                new Game()
                {
                    Id = 5,
                    GameDateTime = new DateTime(2020, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                    TeamAttackerId = 10,
                    TeamDefendantId = 11
                }



            };
            return _Games;
        }

    }
}