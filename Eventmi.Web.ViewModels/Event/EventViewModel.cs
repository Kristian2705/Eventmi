using static Eventmi.Common.EntityValidationConstants.Event;
using Eventmi.Data.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
