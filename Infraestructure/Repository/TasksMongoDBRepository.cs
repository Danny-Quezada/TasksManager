﻿using Domain;
using Domain.Enum;
using Domain.Interfaces;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskStatus = Domain.Enum.TaskStatus;

namespace Infraestructure.Repository
{
	public class TasksMongoDBRepository : IModel<Tasks>, ITaskRepository
	{
		
		private IMongoDatabase db;

		private IMongoCollection<Tasks> Data;
		private IMongoCollection<Tasks> TasksDeleted;
		public TasksMongoDBRepository()
		{
			var client = new MongoClient();
			db = client.GetDatabase("Tasks");
			Data = db.GetCollection<Tasks>("Data");
			TasksDeleted = db.GetCollection<Tasks>("TasksDeleted");
		}
		public void Add(Tasks t)
		{
			DateTime Start = t.StarTime.AddHours(-6);
			DateTime end = t.EndTime.AddHours(-6);
			t.StarTime = Start;
			t.EndTime = end;
			Data.InsertOne(t);
		}

		public void AssingState(Tasks t)
		{
			if (t.StarTime < DateTime.Now) // Example: if it is 10 in the morning and I start the task at 9, 1 hour has already passed.
			{
				t.State = TaskStatus.Started;
			}
			else if (t.StarTime == t.EndTime)
			{
				t.State = TaskStatus.Finished;
			}
			else if (t.StarTime > DateTime.Now)
			{
				t.State = TaskStatus.WithoutStarting;
			}
			else if (t.EndTime == DateTime.Now)
			{
				t.State = TaskStatus.Failed;
			}
			else if (t.EndTime < DateTime.Now)
			{
				t.State = TaskStatus.Failed;
			}
		}

		public void ChangeImportance(Tasks t, TaskImportance Importance)
		{
			throw new NotImplementedException();
		}

		public void ChangeStatus(Tasks t, Domain.Enum.TaskStatus Status)
		{
			var Filter = Builders<Tasks>.Filter.Eq("Id",t.Id);
			var update = Builders<Tasks>.Update.Set("State", Status);
			Data.UpdateOne(Filter, update);

		}

		public void Delete(Tasks t)
		{
			throw new NotImplementedException();
		}

		public Tasks FindTask(int id)
		{
			var filter = Builders<Tasks>.Filter.Eq("Id", id);
			var a= Data.Find(filter).ToList();
			return a[0];
		}

		public Tasks FindTaskDeleted(int Id)
		{
			var filter = Builders<Tasks>.Filter.Eq("Id", Id);
			var a = TasksDeleted.Find(filter).ToList();
			return a[0];
		}

		public void FinishTask(Tasks t)
		{
			if (t.State == Domain.Enum.TaskStatus.Failed)
			{
				var filter = Builders<Tasks>.Filter.Eq("Id", t.Id);
				Data.DeleteOne(filter);
				TasksDeleted.InsertOne(t);
			}
			else if (t.State == Domain.Enum.TaskStatus.Started)
			{
				var filter = Builders<Tasks>.Filter.Eq("Id", t.Id);
				Data.DeleteOne(filter);
				t.State = TaskStatus.Finished;
				TasksDeleted.InsertOne(t); // Podre separar las tareas hechas como las no hechas para los graficos. con LinQ (sum)
			}
			else if (t.State == Domain.Enum.TaskStatus.WithoutStarting)
			{
				var filter = Builders<Tasks>.Filter.Eq("Id", t.Id);
				Data.DeleteOne(filter);
				t.State = Domain.Enum.TaskStatus.Failed;
				TasksDeleted.InsertOne(t);
			}
		}

		public int GetLastId()
		{

			try
			{
				//return Data.Count == 0 ? 0 : (int)Data[Data.Count - 1].GetType().GetProperty("Id").GetValue(Data[Data.Count - 1]);
				return Read(1).Length + Read(2).Length + 1;
			}
			catch (Exception)
			{
				throw new ArgumentException("the object does not have the 'Id' property.");
			}
		}

		public ICollection<Tasks> OrderByChoise(Func<Tasks, bool> Predicate)
		{
			throw new NotImplementedException();
		}

		public void OrderByHours()
		{
			throw new NotImplementedException();
		}

		public Tasks[] Read(int opcion)
		{
			if (opcion == 1)
			{
				return Data.Find(x => true).ToList().ToArray();
			}
			else if (opcion == 2)
			{
				return TasksDeleted.Find(x => true).ToList().ToArray();
			}
			return null;
		}

		public void RetrieveTask(Tasks t)
		{
			var filter = Builders<Tasks>.Filter.Eq("Id", t.Id);
			TasksDeleted.DeleteOne(filter);
			Data.InsertOne(t);
			
		}

		public Tasks TaskById(int id)
		{
			var filter = Builders<Tasks>.Filter.Eq("Id", id);
			var a = Data.Find(filter).ToList();
			return a[0];
		}

		public void Update(Tasks t)
		{
			throw new NotImplementedException();
		}
	}
}