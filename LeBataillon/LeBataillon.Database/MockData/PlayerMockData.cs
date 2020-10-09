using System.Collections.Generic;
using LeBataillon.Database.Models;

namespace LeBataillon.Database.MockData

{
    public static class PlayerMockData
    {
        public static List<Player> GetPlayerTest()
        {
            var _Players = new List<Player>()
            {
                new Player()
                {
                    Id = 1,
                    FirstName = "Benjamin",
                    LastName = "Fabi",
                    NickName = "BenFab",
                    Email = "benjiheadbanger@gmail.com",
                    PhoneNumber = "514-514-1234",
                    Level = 0
                },
                new Player()
                {
                    Id = 2,
                    Email = "Liliana@bataillonMail.com",
                    FirstName = "Liliana",
                    LastName = "Reidcoln",
                    Level = 0,
                    NickName = "LilianaAlias",
                    PhoneNumber = "742-813-7421"
                },
                new Player()
                {
                    Id = 3,
                    Email = "Sheryl@bataillonMail.com",
                    FirstName = "Sheryl",
                    LastName = "Steinstrand",
                    Level = 0,
                    NickName = "SherylAlias",
                    PhoneNumber = "367-252-3834"
                },
                new Player()
                {
                    Id = 4,
                    Email = "Mariella@bataillonMail.com",
                    FirstName = "Mariella",
                    LastName = "Nuugaatrapaluk",
                    Level = 0,
                    NickName = "MariellaAlias",
                    PhoneNumber = "785-411-6446"
                },
                new Player()
                {
                    Id = 5,
                    Email = "Berniece@bataillonMail.com",
                    FirstName = "Berniece",
                    LastName = "Vadtälje",
                    Level = 0,
                    NickName = "BernieceAlias",
                     PhoneNumber = "333-648-2851"
                },
                                new Player()
                {
                    Id = 6,
                    FirstName = "Castre",
                    LastName = "Riptpun",
                    NickName = "fcpbobbrico",
                    Email = "benjirejeantremblay@gmail.com",
                    PhoneNumber = "514-514-1234",
                    Level = 0
                },
                                new Player()
                {
                    Id = 7,
                    FirstName = "Infusionne",
                    LastName = "Lolipipopointnet",
                    NickName = "redventing",
                    Email = "benjitablettechocolat@gmail.com",
                    PhoneNumber = "514-514-1234",
                    Level = 0
                },
                                new Player()
                {
                    Id = 8,
                    FirstName = "Monitorgane",
                    LastName = "Venderarme",
                    NickName = "vadansleslymbes",
                    Email = "benjirogerroger@gmail.com",
                    PhoneNumber = "514-514-1234",
                    Level = 0
                },
                                new Player()
                {
                    Id = 9,
                    FirstName = "Juviette",
                    LastName = "Glandluc",
                    NickName = "Truncatedatabase",
                    Email = "benjiattention@gmail.com",
                    PhoneNumber = "514-514-1234",
                    Level = 0
                },
                                new Player()
                {
                    Id = 10,
                    FirstName = "Ronald",
                    LastName = "Fabi",
                    NickName = "Ronny",
                    Email = "benjilecave@gmail.com",
                    PhoneNumber = "514-514-1234",
                    Level = 0
                },


            };
            return _Players;
        }
    }
}