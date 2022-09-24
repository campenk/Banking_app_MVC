using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIT706_A2_Campen_5047211
{
    class AccountSingleton
    {
		private int nextId;
		private static AccountSingleton myInstance;

		public static int NextId
		{
			get
			{
				getInstance().nextId++;
				return myInstance.nextId;
			}
		}

		public static AccountSingleton getInstance()
		{
			if (myInstance == null)
			{
				myInstance = new AccountSingleton();
			}

			return myInstance;
		}

		public static void setInstance(AccountSingleton s)
		{
			myInstance = s;
		}

		private AccountSingleton() { }
	}
}
