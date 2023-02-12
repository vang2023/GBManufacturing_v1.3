using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBManufacturing
{
	[Serializable]
	public class Manager : Employee
	{
		// attributes
		private string password;

		// constructors
		public Manager() : base()
		{
			Password = "N/A";
		}

		public Manager(string employeeID, string firstName, string lastName, string password)
			: base(employeeID, firstName, lastName)
		{
			Password = password;
		}

		public string Password
		{			
			set
			{
				if (password != "N/A")
					password = value;
				else
					password = "N/A";
			}
			get { return password; }
		}

		// behaviors
		public override string ToString()
		{
			return "Password: " + password;
		}
	}
}
