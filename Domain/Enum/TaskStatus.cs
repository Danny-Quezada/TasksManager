using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Enum
{
	public enum TaskStatus
	{
		Finished,
		WithoutStarting,
		Started,
		Failed,
		Warning
	}
}
