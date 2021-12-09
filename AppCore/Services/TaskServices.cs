﻿using AppCore.IServices;
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

		public void FinishTaskDone(Tasks t)
		{
			Repository.FinishTaskDone(t);
		}

		public ICollection<Tasks> OrderByChoise(Func<Tasks, bool> Predicate)
		{
			return Repository.OrderByChoise(Predicate);
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
		public void AssingState(Tasks t)
		{
			Repository.AssingState(t);
		}
	}
}
