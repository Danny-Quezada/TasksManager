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
		protected List<T> Datos;
		protected BaseRepository()
		{
			Datos = new List<T>();
		}
		public void Add(T t)
		{
			Datos.Add(t);
		}

		public void Delete(T t)
		{
			Datos.Remove(t);
		}

		public virtual int GetLastId()
		{
		
				try
				{
					return Datos.Count == 0 ? 0 : (int)Datos[Datos.Count - 1].GetType().GetProperty("Id").GetValue(Datos[Datos.Count - 1]);
				}
				catch (Exception)
				{
					throw new ArgumentException("El objeto no posee la propiedad Id");
				}
		}

		public T[] Read()
		{
			return Datos.ToArray();
		}

		
	}
}
