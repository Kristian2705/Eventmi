namespace Eventmi.Data.Models
{
    using Eventmi.Common;
    using Eventmi.Data.Models.Enums;
    using System;
    using System.ComponentModel.DataAnnotations;
    public class Event
	{
		[Key]
        public int Id { get; set; }
		[Required]
        [MaxLength(EntityValidationConstants.Event.NameMaxLength)]
        public string? Name { get; set; }
		[Required]
        public DateTime Start { get; set; }
		[Required]
        public DateTime End { get; set; }
		[Required]
        public string? Place { get; set; }

        [Required]
        public Category Category { get; set; }
    }
}
