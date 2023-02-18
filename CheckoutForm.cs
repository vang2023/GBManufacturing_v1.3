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

		// create attributes to go between forms
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

		// populate the textboxes with the above attributes
		private void CheckoutForm_Load(object sender, EventArgs e)
		{
			txtTransaction.Text = Convert.ToString(Transaction);
			txtEmployeeID.Text = Convert.ToString(EmployeeID);
			txtToolID.Text = ToolID;
			txtToolManufacturer.Text = Manufacturer;
			txtToolDescription.Text = Description;
			txtQuantity.Text = Convert.ToString(Quantity);
		}	

		// saves employee ID and tool data to tool_event.csv file
		private void btnSubmit_Click(object sender, EventArgs e)
		{
			// assign checkout form textboxes information to variables
			int trans = Int32.Parse(txtTransaction.Text);
			string empID = txtEmployeeID.Text;
			string toolID = txtToolID.Text;
			string manufacturer = txtToolManufacturer.Text;
			string description = txtToolDescription.Text;
			int qty = Int32.Parse(txtQuantity.Text);

			var lines = File.ReadAllLines(EMPLOYEEFILECSV); // variable to hold csv lines
			var list = new List<Employee>();                // create list of Tool objects

			// write transaction data to tool event file
			File.AppendAllText(TOOLEVENTFILECSV, $"{trans},{empID},{ToolID},{manufacturer},{description},{qty}\n");
			MessageBox.Show("Employee ID found, transaction completed.");

			// ALTERNATE METHOD TO WRITE TO CSV
			//using (System.IO.StreamWriter file = new System.IO.StreamWriter(TOOLEVENTFILECSV, true))
			//{
			//	file.Write(trans + "," + empid + "," + tid + "," + manufacturer + ","
			//		+ description + "," + description + "," + qty + '\n');
			//}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;	// cancels the transaction
		}
	}
}
