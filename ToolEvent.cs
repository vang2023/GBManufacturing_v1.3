using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBManufacturing
{
	public class ToolEvent
	{
		int transactionNumber;
		protected Employee employeeID;
		protected Tool toolID;
		protected Tool toolManufacturer;
		protected Tool toolDescription;
		protected Tool toolQuantity;

		public ToolEvent() : base()
		{
			TransactionNumber = 0;
			EmployeeID = new Employee();
			ToolID = new Tool();
			ToolManufacturer = new Tool();
			ToolDescription = new Tool();
			ToolQuantity = new Tool();
		}

		public ToolEvent(int transactionNumber, Employee employeeID, Tool toolID, 
			Tool toolManufacturer, Tool toolDescription, Tool toolQuantity)
		{
			TransactionNumber = transactionNumber;
			EmployeeID = employeeID;
			ToolID = toolID;
			ToolManufacturer = toolManufacturer;
			ToolDescription = toolDescription;
			ToolQuantity = toolQuantity;
		}

		public int TransactionNumber
		{
			set { transactionNumber = value; }
			get { return transactionNumber; }
		}

		public Employee EmployeeID
		{
			set { employeeID = value; }
			get { return employeeID; }
		}

		public Tool ToolID
		{
			set { toolID = value; }
			get { return toolID; }
		}

		public Tool ToolManufacturer
		{
			set { toolManufacturer = value; }
			get { return toolManufacturer; }
		}

		public Tool ToolDescription
		{
			set { toolDescription = value; }
			get { return toolDescription; }
		}

		public Tool ToolQuantity
		{
			set { toolQuantity = value; }
			get { return toolQuantity; }
		}

		public override string ToString()
		{
			return "Transaction:" + transactionNumber.ToString() + ", Employee ID: " + EmployeeID + ", Tool ID: " + ToolID 
				+ ", Tool Manufacturer: " + ToolManufacturer + ", Tool Description: " + ToolDescription 
				+ ", Quantity: " + ToolQuantity.ToString();
		}
	}	
}
