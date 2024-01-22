namespace Eventmi.Data.Models
{
	using Eventmi.Common;
	using System;
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;
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
    }
}
