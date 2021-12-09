using AppCore.IServices;
using AppCore.Services;
using Autofac;
using Domain.Interfaces;
using Infraestructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManagers.Forms;

namespace TaskManagers
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			var builder = new ContainerBuilder();

			builder.RegisterType<TasksListRepository>().As<ITaskRepository>();
			builder.RegisterType<TaskServices>().As<ITaskServices>();
			Application.EnableVisualStyles();

			var container = builder.Build();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new FrmTasks(container.Resolve<ITaskServices>()));
		}
	}
}
