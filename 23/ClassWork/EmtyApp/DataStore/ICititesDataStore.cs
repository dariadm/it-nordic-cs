using EmtyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmtyApp.DataStore
{
	public interface ICititesDataStore
	{
		List<CityGetModel> Cities { get;}
	}
}
