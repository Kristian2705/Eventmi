using Eventmi.Data.Models.Enums;
using System.ComponentModel.DataAnnotations;
using static Eventmi.Common.EntityValidationConstants.Event;

namespace Eventmi.Web.ViewModels.Event
{
    public class EventViewModel
	{
        public int Id { get; set; }
        [StringLength(NameMaxLength, MinimumLength = NameMinLength)]
		public string? Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        [EnumDataType(typeof(Category))]
        public Category Category { get; set; }

        [StringLength(PlaceMaxLength, MinimumLength = PlaceMinLength)]
        public string? Place { get; set; }
    }
}
