using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBManufacturing
{
	public class ToolEvent
	{
		// attributes
		protected int transactionNumber;
		protected Employee employee;
		protected Tool tool;

		// constructors
		public ToolEvent() : base()
		{
			TransactionNumber = 0;
			EmpObj = new Employee();
			ToolObj = new Tool();
		}

		public ToolEvent(int transactionNumber, Employee employee, Tool tool)
		{
			TransactionNumber = transactionNumber;
			EmpObj = employee;
			ToolObj = tool;
		}

		// properties
		public int TransactionNumber
		{
			set { transactionNumber = value; }
			get { return transactionNumber; }
		}

		public Employee EmpObj
		{
			set { this.employee = value; }
			get { return employee; }
		}

		public Tool ToolObj
		{
			set { this.tool = value; }
			get { return tool; }
		}

		// behaviors
		public override string ToString()
		{
			return transactionNumber.ToString() + ", " + EmpObj + ", " + ToolObj;
		}
	}	
}
