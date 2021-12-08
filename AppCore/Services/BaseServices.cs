using AppCore.IServices;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Services
{
	public abstract class BaseServices<T> : IServices<T>
	{
		private IModel<T> Model;
		protected BaseServices(IModel<T> model)
		{
			this.Model = model;
		}


		public void Add(T t)
		{
			Model.Add(t);
		}

		public void Delete(T t)
		{
			Model.Delete(t);
		}

		public int GetLastId()
		{
			return Model.GetLastId();
		}

		public T[] Read()
		{
			return Model.Read();
		}
	}
}
