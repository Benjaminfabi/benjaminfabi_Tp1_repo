using System;
using System.ComponentModel.DataAnnotations;


namespace LeBataillon.Database.Models
{
    public class DatetimeAnnotation : ValidationAttribute
    {
        public DateTime Minimum { get; set; }
        public DateTime Maximum { get; set; }

        public DatetimeAnnotation()
        {

            this.Minimum = DateTime.Now.AddHours(24);
            this.Maximum = DateTime.MaxValue;
        }



    }
}