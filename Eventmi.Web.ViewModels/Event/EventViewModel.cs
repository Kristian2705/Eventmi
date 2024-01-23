using Eventmi.Common.Validations;
using Eventmi.Data.Models.Enums;
using System.ComponentModel.DataAnnotations;
using static Eventmi.Common.Constants.EntityValidationConstants.Event;

namespace Eventmi.Web.ViewModels.Event
{
    public class EventViewModel
	{
        [Required]
        [StringLength(NameMaxLength, MinimumLength = NameMinLength)]
		public string? Name { get; set; }
        [Required]
        [ValidDate]
        public string? StartDate { get; set; }
        [Required]
        [ValidDate]
        public string? EndDate { get; set; }
        [Required]
        [EnumDataType(typeof(Category))]
        public Category Category { get; set; }

        [Required]
        [StringLength(PlaceMaxLength, MinimumLength = PlaceMinLength)]
        public string? Place { get; set; }
    }
}
