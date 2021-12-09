using Domain;
using Domain.Enum;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskStatus = Domain.Enum.TaskStatus;

namespace Infraestructure.Repository
{
	public class TasksListRepository : BaseRepository<Tasks>, ITaskRepository
	{
		List<Tasks> TareasEliminadas;
		public TasksListRepository()
		{
			TareasEliminadas = new List<Tasks>();
		}

		public void AssingState(Tasks t)
		{
			if (t.StarTime == DateTime.Now)
			{
				t.State = TaskStatus.Started;
			}
			else if (t.StarTime == t.EndTime)
			{
				t.State = TaskStatus.Finished;
			}
			else if (t.StarTime < DateTime.Now)
			{
				t.State = TaskStatus.WithoutStarting;
			}
			else if (t.EndTime == DateTime.Now)
			{
				t.State = TaskStatus.Failed;
			}
		}

		public void ChangeImportance(Tasks t,TaskImportance Importance)
		{
			for(int i=0; i<Datos.Count; i++)
			{
				if (t.Id == Datos[i].Id)
				{
					Datos[i].Importance = Importance;
					break;
				}
			}
		}

		public void ChangeStatus(Tasks t,TaskStatus Status)
		{
			for (int i = 0; i < Datos.Count; i++)
			{
				if (t.Id == Datos[i].Id)
				{
					Datos[i].State = Status;
					break;
				}
			}
		}
		
		public Tasks FindTask(int id)
		{
			for (int i = 0; i < Datos.Count; i++)
			{
				if (id == Datos[i].Id)
				{
					return Datos[i];
				}
			}
			return null;
		}

		public void FinishTaskDone(Tasks t)
		{
			Datos.Remove(t);
			t.State = TaskStatus.Finished;
			TareasEliminadas.Add(t);

		}

		public ICollection<Tasks> OrderByChoise(Func<Tasks,bool> Predicate)
		{
			return Datos.Where(Predicate).ToList();
		}

		public void RememberTime()
		{
			throw new NotImplementedException();
		}

		public void RetrieveTask(Tasks t)
		{
			if (TareasEliminadas.Count == 0)
			{
				new Exception("No hay ninguna tarea eliminada");
				return;
			}
			for(int i=0; i<TareasEliminadas.Count; i++)
			{
				if (t.Id == TareasEliminadas[i].Id)
				{
					t.State = TaskStatus.Started;
					Datos.Add(t);
					TareasEliminadas.Remove(t);
					break;
				}
			}
		}

		public Tasks TaskById(int id)
		{
		
			for (int i = 0; i < Datos.Count; i++)
			{
				if (id == Datos[i].Id)
				{
					return Datos[i];
				
				}
			}
			return null;
		}

		public void Update(Tasks t)
		{
			bool Actualizado = false;
			for(int i=0; i<Datos.Count; i++)
			{
				if (t.Id == Datos[i].Id)
				{
					Datos.Insert(i, t);
					Actualizado = true;
				}
			}
			if (Actualizado == false)
			{
				new Exception("No se pudo actualizar");
			}
		}
	}
}
