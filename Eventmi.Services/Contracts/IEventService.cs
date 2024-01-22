using Eventmi.Web.ViewModels.Event;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventmi.Services.Contracts
{
	public interface IEventService
	{
		Task AddAsync(EventViewModel model);
	}
}
