using Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskStatus = Domain.Enum.TaskStatus;

namespace Domain.Interfaces
{
	public interface ITaskRepository: IModel<Tasks>
	{

		void ChangeStatus(Tasks t, TaskStatus Status);
		void ChangeImportance(Tasks t,TaskImportance Importance);
		Tasks FindTask(int id);
		Tasks TaskById(int id);
		void RetrieveTask(Tasks t);
		void FinishTask(Tasks t);
		ICollection<Tasks> OrderByChoise(Func<Tasks,bool> Predicate);
		void Update(Tasks t);

		void AssingState(Tasks t);

		void OrderByHours();
		Tasks FindTaskDeleted(int Id);
		

	}
}
