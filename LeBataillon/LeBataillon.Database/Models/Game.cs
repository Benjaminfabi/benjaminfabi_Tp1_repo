using System;
using System.ComponentModel.DataAnnotations;

namespace LeBataillon.Database.Models
{

    public class Game
    {
        public Game()
        {
        }
        public Game(int Id, DateTime GameDateTime, int TeamDefendant, int TeamAttacker)
        {
            this.Id = Id;
            this.GameDateTime = GameDateTime;
            this.TeamDefendantId = TeamDefendant;
            this.TeamAttackerId = TeamAttacker;
        }
        public void EditFrom(Game g)
        {
            this.Id = g.Id;
            this.GameDateTime = g.GameDateTime;
            this.TeamDefendant = g.TeamDefendant;
            this.TeamAttacker = g.TeamAttacker;
        }
        public int Id { get; set; }
        [DatetimeAnnotation(ErrorMessage = "You can only schedule in 24 hours or more")]
        [Required(ErrorMessage = "Please enter a date")]
        public DateTime GameDateTime { get; set; }
        public int? TeamDefendantId { get; set; }
        public virtual Team TeamDefendant { get; set; }
        public int? TeamAttackerId { get; set; }
        public virtual Team TeamAttacker { get; set; }

        public GameStatus gameStatus { get; set; }
    }
}