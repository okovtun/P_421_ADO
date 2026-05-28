using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using DBtools;

namespace Academy
{
	static class DataBase
	{
		public static Connector Connector { get; set; }
		static DataBase()
		{
			Connector = new Connector
				(
				ConfigurationManager.ConnectionStrings["P_421_Import"].ConnectionString
				);
		}
	}
}
