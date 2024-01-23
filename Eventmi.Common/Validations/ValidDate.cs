using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventmi.Common.Validations
{
	public class ValidDate : ValidationAttribute
	{
		public override bool IsValid(object value)
		{
			DateTime dateTime;

			var isValid = DateTime.TryParseExact(Convert.ToString(value),
				"dd/MM/yyyy",
				CultureInfo.CurrentCulture,
				DateTimeStyles.None,
				out dateTime);

			return isValid;
		}
	}
}
