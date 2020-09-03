using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
	public class EmpresaFacadeSingleton
	{
		private static EmpresaFacade _facade = new EmpresaFacade();
		public EmpresaFacade Facade 
		{ 
			get
			{
				return _facade;
			}
		}
	}
}
