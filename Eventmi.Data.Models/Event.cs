namespace Eventmi.Data.Models
{
    using Eventmi.Common.Constants;
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
        public DateTime StartDate { get; set; }
		[Required]
        public DateTime EndDate { get; set; }
		[Required]
        public string? Place { get; set; }

        [Required]
        public Category Category { get; set; }
    }
}
