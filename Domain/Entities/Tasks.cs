
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
		public int Id { get; set; }
		public DateTime StarTime { get; set; }
		public DateTime EndTime { get; set; }
		public string Description { get; set; }

		public TaskStatus State { get; set; }
		public TaskImportance Importance { get; set; }

	}
}
