using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIT706_A2_Campen_5047211
{
	class CustomerSingleton
	{
		private int nextId;
		private static CustomerSingleton myInstance;

		public static int NextId
		{
			get
			{
				getInstance().nextId++;
				return myInstance.nextId;
			}
		}

		public static CustomerSingleton getInstance()
		{
			if (myInstance == null)
			{
				myInstance = new CustomerSingleton();
			}

			return myInstance;
		}

		public static void setInstance(CustomerSingleton s)
		{
			myInstance = s;
		}

		private CustomerSingleton() { }
	}
}
