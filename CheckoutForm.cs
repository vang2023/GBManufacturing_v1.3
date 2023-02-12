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
			Transaction = Int32.Parse(txtTransaction.Text);
			EmployeeID = txtEmployeeID.Text;
			ToolID = txtToolID.Text;
			Manufacturer = txtToolManufacturer.Text;
			Description = txtToolDescription.Text;
			Quantity = Int32.Parse(txtQuantity.Text);

			//compare employee id to EMPLOYEE file
			VerifyEmployeeID(EmployeeID);

			//ToolEvent toolEvent = new ToolEvent(Transaction, EmployeeID, ToolID, Manufacturer, Description, Quantity);
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
		}

		//method to verify employee ID
		public string VerifyEmployeeID(string employeeID)
		{
			var lines = File.ReadAllLines(EMPLOYEEFILECSV);    //variable to hold csv lines
			var list = new List<Employee>();                //create list of Tool objects

			foreach (var line in lines)                 //separate the values for each line
			{
				var values = line.Split(',');
				string empid = values[0];       //convert the quantity to int then assign to another variable
				if (employeeID != empid)
				{
					MessageBox.Show("Employee ID not found. Please re-enter:");
					break;					
				}
				else
				{
					return employeeID;
				}					
			}
		}
	}
}
