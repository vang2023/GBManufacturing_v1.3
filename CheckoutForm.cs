using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GBManufacturing
{
	public partial class CheckoutForm : Form
	{
		const string EMPLOYEEFILECSV = "employee_data.csv";
		const string TOOLEVENTFILECSV = "tool_event.csv";

		//create attributes to go between forms
		public int Transaction { get; set; }
		public string EmployeeID { get; set; }
		public string ToolID { get; set; }
		public string Manufacturer { get; set; }
		public string Description { get; set; }
		public int Quantity { get; set; }

		public CheckoutForm()
		{
			InitializeComponent();
		}

		//set the textboxes to the above attributes
		private void CheckoutForm_Load(object sender, EventArgs e)
		{
			txtTransaction.Text = Convert.ToString(Transaction);
			txtEmployeeID.Text = Convert.ToString(EmployeeID);
			txtToolID.Text = ToolID;
			txtToolManufacturer.Text = Manufacturer;
			txtToolDescription.Text = Description;
			txtQuantity.Text = Convert.ToString(Quantity);
		}	

		//Submit button saves data to tool_event.csv file
		private void btnSubmit_Click(object sender, EventArgs e)
		{
			//assign checkout form information to variables
			int trans = Int32.Parse(txtTransaction.Text);
			string empid = txtEmployeeID.Text;
			string tid = txtToolID.Text;
			string manufacturer = txtToolManufacturer.Text;
			string description = txtToolDescription.Text;
			int qty = Int32.Parse(txtQuantity.Text);

			//write transaction data to tool event file
			File.AppendAllText(TOOLEVENTFILECSV, $"{trans},{empid},{tid},{manufacturer},{description},{qty}\n");

			//alternate method
			//using (System.IO.StreamWriter file = new System.IO.StreamWriter(TOOLEVENTFILECSV, true))
			//{
			//	file.Write(trans + "," + empid + "," + tid + "," + manufacturer + ","
			//		+ description + "," + description + "," + qty + '\n');
			//}

			//compare employee id to EMPLOYEE file
			//VerifyEmployeeID(empid);
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
		}

		//method to verify employee ID
		//public void VerifyEmployeeID(string employeeID)
		//{
		//	var lines = File.ReadAllLines(EMPLOYEEFILECSV);    //variable to hold csv lines
		//	var list = new List<Employee>();                //create list of Tool objects

		//	foreach (var line in lines)
		//	{
		//		var values = line.Split(',');
		//		if (values.Length == 3)
		//		{
		//			var emp = new Employee()
		//			{
		//				EmployeeID = values[0],
		//				FirstName = values[1],
		//				LastName = values[2]
		//			};					
		//		}
		//	}
		//}
	}
}
