using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeBataillon.Database.Models
{
    public class Team
    {

        public Team()
        {


        }

        public Team(int Id, string TeamName, Player Captain)
        {
            this.Id = Id;
            this.TeamName = TeamName;
            this.Captain = Captain;

        }

        public void EditFrom(Team t)
        {
            this.Id = t.Id;
            this.TeamName = t.TeamName;
            this.Captain = t.Captain;

        }
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string TeamName { get; set; }
        [MaxLength(1)]
        [Required]
        public Player Captain { get; set; }

        public virtual List<Player> ListPlayers { get; set; }
    }
}