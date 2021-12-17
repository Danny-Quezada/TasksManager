
using Domain.Enum;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
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
		[BsonElement]
		public int Id { get; set; }
		[BsonRepresentation(BsonType.Document)]
		public DateTime StarTime { get; set; }
		[BsonRepresentation(BsonType.Document)]
		public DateTime EndTime { get; set; }
		[BsonElement]
		public string Description { get; set; }
		[BsonElement]
		public TaskStatus State { get; set; }
		[BsonElement]
		public TaskImportance Importance { get; set; }

		
	}
}
