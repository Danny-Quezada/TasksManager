using AppCore.IServices;
using Domain;
using Domain.Enum;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskStatus = Domain.Enum.TaskStatus;

namespace AppCore.Services
{
	public class TaskServices : BaseServices<Tasks>,ITaskServices
	{
		private ITaskRepository Repository;
		private static ITaskRepository Services;

		private static TaskServices _Instace;
		public TaskServices GetInstance()
		{
			if (_Instace == null)
			{
				_Instace = new TaskServices(Repository);
			}
			return _Instace;
		}

		public TaskServices(ITaskRepository repository) : base(repository)
		{
			this.Repository = repository;
		}

	
		public void ChangeImportance(Tasks t, TaskImportance Importance)
		{
			Repository.ChangeImportance( t,Importance);
		}

		public void ChangeStatus(Tasks t, TaskStatus Status)
		{
			Repository.ChangeStatus(t,Status);
		}

		public Tasks FindTask(int id)
		{
			return Repository.FindTask(id);
		}

	

		public ICollection<Tasks> OrderByChoise(Func<Tasks, bool> Predicate)
		{
			return Repository.OrderByChoise(Predicate);
		}

	

		public void RetrieveTask(Tasks t)
		{
			Repository.RetrieveTask(t);
		}

		public Tasks TaskById(int id)
		{
			return Repository.TaskById(id);
		}

		public void Update(Tasks t)
		{
			Repository.Update(t);
		}
		public void AssingState(Tasks t)
		{
			Repository.AssingState(t);
		}

		public void FinishTask(Tasks t)
		{
			Repository.FinishTask(t);
		}

		public void OrderByHours()
		{
			Repository.OrderByHours();
		}

		public Tasks FindTaskDeleted(int Id)
		{
			return Repository.FindTaskDeleted(Id);
		}

		public override int GetLastId()
		{
			return Repository.GetLastId();
		}
	}
}
