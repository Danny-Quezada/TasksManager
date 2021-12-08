using AppCore.IServices;
using Domain;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Services
{
	public class TaskServices : BaseServices<Tasks>,ITaskServices
	{
		private ITaskRepository Repository;

		public TaskServices(ITaskRepository repository) : base(repository)
		{
			this.Repository = repository;
		}

		public void ChangeImportance(Tasks t)
		{
			Repository.ChangeImportance( t);
		}

		public void ChangeStatus(Tasks t)
		{
			Repository.ChangeStatus(t);
		}

		public Tasks FindTask(int id)
		{
			return Repository.FindTask(id);
		}

		public void FinishTaskDone(Tasks t)
		{
			Repository.FinishTaskDone(t);
		}

		public void OrderByChoise(Predicate<Tasks> Predicate)
		{
			Repository.OrderByChoise(Predicate);
		}

		public void RememberTime()
		{
			Repository.RememberTime();
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
	}
}
