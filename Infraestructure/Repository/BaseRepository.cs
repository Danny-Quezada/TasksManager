using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository
{
	public abstract class BaseRepository<T> : IModel<T>
	{
		protected List<T> Data;
		protected BaseRepository()
		{
			Data = new List<T>();
		}
		public void Add(T t)
		{
			Data.Add(t);
		}

		public void Delete(T t)
		{
			Data.Remove(t);
		}

		public virtual int GetLastId()
		{

			try
			{
				//return Data.Count == 0 ? 0 : (int)Data[Data.Count - 1].GetType().GetProperty("Id").GetValue(Data[Data.Count - 1]);
				return Data.Count + 1;
			}
			catch (Exception)
			{
				throw new ArgumentException("the object does not have the 'Id' property.");
			}
		}

		public abstract T[] Read(int opcion);
	

		
	}
}
