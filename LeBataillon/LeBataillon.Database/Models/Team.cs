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

        public Team(int Id, string TeamName, int Captain)
        {
            this.Id = Id;
            this.TeamName = TeamName;
            this.CaptainId = Captain;

        }

        public void EditFrom(Team t)
        {
            this.Id = t.Id;
            this.TeamName = t.TeamName;
            this.CaptainId = t.CaptainId;

        }

        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "A team name is required.")]
        [MaxLength(25, ErrorMessage = "Le nom de l'équipe ne peut pas dépasser 25 caractères")]
        public string TeamName { get; set; }

        public int CaptainId { get; set; }

        [Required(ErrorMessage = "A team captain is required.")]
        [ForeignKey("CaptainId")]
        public virtual Player Captain { get; set; }

        [InverseProperty("Team")]


        public virtual List<Player> Players { get; set; }
    }
}