using Domain;
using Domain.Enum;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using TaskStatus = Domain.Enum.TaskStatus;

namespace Infraestructure.Repository
{
	public class TasksListRepository : BaseRepository<Tasks>, ITaskRepository
	{
		List<Tasks> TasksDeleted;
		

		public TasksListRepository()
		{
			TasksDeleted = new List<Tasks>();
		
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

		public void ChangeImportance(Tasks t,TaskImportance Importance)
		{
			for(int i=0; i<Data.Count; i++)
			{
				if (t.Id == Data[i].Id)
				{
					Data[i].Importance = Importance;
					break;
				}
			}
		}

		public void ChangeStatus(Tasks t,TaskStatus Status)
		{
			for (int i = 0; i < Data.Count; i++)
			{
				if (t.Id == Data[i].Id)
				{
					Data[i].State = Status;
					break;
				}
			}
		}
		public Tasks FindTask(int id)
		{
			for (int i = 0; i < Data.Count; i++)
			{
				if (id == Data[i].Id)
				{
					return Data[i];
				}
			}
			return null;
		}

		public Tasks FindTaskDeleted(int Id)
		{
			for (int i = 0; i < TasksDeleted.Count; i++)
			{
				if (Id == TasksDeleted[i].Id)
				{
					return TasksDeleted[i];
				}
			}
			return null;
		}

		public void FinishTask(Tasks t)
		{
			if (t.State == Domain.Enum.TaskStatus.Failed)
			{
				Data.Remove(t);
				TasksDeleted.Add(t);
			}
			else if (t.State == Domain.Enum.TaskStatus.Started)
			{
				Data.Remove(t);
				t.State = TaskStatus.Finished;
				TasksDeleted.Add(t); // Podre separar las tareas hechas como las no hechas para los graficos. con LinQ (sum)
			}
			else if(t.State == Domain.Enum.TaskStatus.WithoutStarting)
			{
				Data.Remove(t);
				t.State = Domain.Enum.TaskStatus.Failed;
				TasksDeleted.Add(t);
			}

		}

		public override int GetLastId()
		{

			try
			{
				//return Data.Count == 0 ? 0 : (int)Data[Data.Count - 1].GetType().GetProperty("Id").GetValue(Data[Data.Count - 1]);
				return Data.Count + TasksDeleted.Count+1;
			}
			catch (Exception)
			{
				throw new ArgumentException("the object does not have the 'Id' property.");
			}
		}

		public ICollection<Tasks> OrderByChoise(Func<Tasks,bool> Predicate)
		{
			return Data.Where(Predicate).ToList();
		}

		public void OrderByHours()
		{
			Data.Sort((x, y) => x.StarTime.CompareTo(y.StarTime));
		}

		public override Tasks[] Read(int opcion)
		{
			switch (opcion)
			{
				case 1:
					return Data.ToArray();
				case 2:
					return TasksDeleted.ToArray();
				default:
					return null;
			}
		}

		public void RetrieveTask(Tasks t)
		{
			for(int i=0; i < TasksDeleted.Count; i++)
			{
				if (t.Id == TasksDeleted[i].Id)
				{
					TasksDeleted.RemoveAt(i);
					Data.Add(t);
					break;
				}
			}
			
		}



		public Tasks TaskById(int id)
		{
		
			for (int i = 0; i < Data.Count; i++)
			{
				if (id == Data[i].Id)
				{
					return Data[i];
				
				}
			}
			return null;
		}

		public void Update(Tasks t)
		{
			bool Actualizado = false;
			for(int i=0; i<Data.Count; i++)
			{
				if (t.Id == Data[i].Id)
				{
					Data.Insert(i, t);
					Actualizado = true;
				}
			}
			if (Actualizado == false)
			{
				new Exception("Could not update.");
			}
		}
	}
}
