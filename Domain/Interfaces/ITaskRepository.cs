﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
	public interface ITaskRepository: IModel<Tasks>
	{

		void ChangeStatus(Tasks t);
		void ChangeImportance(Tasks t);
		void RememberTime();
		Tasks FindTask(int id);
		Tasks TaskById(int id);
		void RetrieveTask(Tasks t);
		void FinishTaskDone(Tasks t);
		void OrderByChoise(Predicate<Tasks> Predicate);
		void Update(Tasks t);

		

	}
}
