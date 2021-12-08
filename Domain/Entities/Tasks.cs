
using Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskStatus = Domain.Enum.TaskStatus;

namespace Domain
{
	public class Tasks
	{
		int Id { get; set; }
		DateTime StarTime { get; set; }
		DateTime EndTime { get; set; }
		string Description { get; set; }

		TaskStatus State { get; set; }
		TaskImportance Importance { get; set; }

	}
}
