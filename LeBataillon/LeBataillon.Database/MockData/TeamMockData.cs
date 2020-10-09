using System.Collections.Generic;
using LeBataillon.Database.Models;

namespace LeBataillon.Database.MockData
{
    public class TeamMockData
    {
        public static List<Team> GetTeamTest()
        {
            var _Teams = new List<Team>()
            {
                new Team
                {
                    Id = 1,
                    CaptainId = 1,
                    TeamName = "Équipe de frootloops"
                },
                new Team
                {
                    Id = 2,
                    CaptainId = 2,
                    TeamName = "Équipe de equipesansnom"
                },
                new Team
                {
                    Id = 3,
                    CaptainId = 3,
                    TeamName = "Équipe de Pawdwdwd"
                },
                new Team
                {
                    Id = 4,
                    CaptainId = 4,
                    TeamName = "Équipe de Ilestuneheuremat"
                },
                new Team
                {
                    Id = 5,
                    CaptainId = 5,
                    TeamName = "Équipe de tannerdutp"
                },
                new Team
                {
                    Id = 6,
                    CaptainId = 6,
                    TeamName = "Équipe de getthefodgeout"
                },
                new Team
                {
                    Id = 7,
                    CaptainId = 7,
                    TeamName = "Équipe de fnatic"
                },
                new Team
                {
                    Id = 8,
                    CaptainId = 8,
                    TeamName = "Équipe de gargantua"
                },
                new Team
                {
                    Id = 9,
                    CaptainId = 9,
                    TeamName = "Équipe de rogerlapresse"
                },
                new Team
                {
                    Id = 10,
                    CaptainId = 10,
                    TeamName = "Équipe de Sains dona"
                }

            };
            return _Teams;
        }
    }
}