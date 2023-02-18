using LINQtoCSV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GBManufacturing
{
	public partial class MainMenu : Form
	{
		const string DRILLFILECSV = "drills.csv";
		const string IMPACTDRIVERFILECSV = "impact_drivers.csv";
		const string TOOLEVENTFILECSV = "tool_event.csv";
		const string EMPLOYEEFILECSV = "employee_data.csv";
		string _newline = Environment.NewLine;

		public MainMenu()
		{
			InitializeComponent();
		}

		private void btnCheckout_Click(object sender, EventArgs e)
		{
			//listbox item is assigned to Tool object
			Tool toolSelected = (Tool)listTools.SelectedItem;

			//create instance of second form
			CheckoutForm checkoutForm = new CheckoutForm();

			//generate a random number for the TRANSACTION and output in textbox
			Random randomNumber = new Random();
			int newTransactionNumber = randomNumber.Next(100000, 1000000);


			string empid = checkoutForm.txtEmployeeID.Text;     //convert then add the EMPLOYEE ID FROM THE EMPLOYEE TEXTBOX
			string toolid = checkoutForm.ToolID;                //create the rest of the variables for checkout info
			string manufacturer = checkoutForm.Manufacturer;
			string description = checkoutForm.Description;
			int quantity = checkoutForm.Quantity;

			if (toolSelected != null)	//make sure item is selected
			{
				//send data from checkoutForm's textboxes to public ToolEvent attributes
				checkoutForm.Transaction = newTransactionNumber;
				checkoutForm.EmployeeID = empid;
				checkoutForm.ToolID = toolSelected.ToolID;
				checkoutForm.Manufacturer = toolSelected.ToolManufacturer;
				checkoutForm.Description = toolSelected.ToolDescription;
				checkoutForm.Quantity = toolSelected.ToolQuantity;
			}
			
			//display the checkout form
			DialogResult result = checkoutForm.ShowDialog();

			//
			if (result == DialogResult.OK)
			{
				toolSelected.ToolID = checkoutForm.ToolID;
				toolSelected.ToolDescription = checkoutForm.Manufacturer;
				toolSelected.ToolManufacturer = checkoutForm.Description;
				toolSelected.ToolQuantity = checkoutForm.Quantity;
				newTransactionNumber = checkoutForm.Transaction;
			}
		}

		private void btnOrder_Click(object sender, EventArgs e)
		{
			
		}

		private void btnReturn_Click(object sender, EventArgs e)
		{

		}

		private void btnShip_Click(object sender, EventArgs e)
		{

		}

		private void chkBoxDrills_CheckedChanged(object sender, EventArgs e)
		{
			if (chkBoxDrills.Checked)
			{
				ReadToolCSV(DRILLFILECSV);
			}
		}

		private void chkBoxImpactDriver_CheckedChanged(object sender, EventArgs e)
		{
			if (chkBoxImpactDriver.Checked)
			{
				ReadToolCSV(IMPACTDRIVERFILECSV);
			}
		}

		private void chkBoxAll_CheckedChanged(object sender, EventArgs e)
		{
			ReadToolCSV(DRILLFILECSV);						//read and print the drill file data
			listTools.Items.Add(_newline);
			ReadToolCSV(IMPACTDRIVERFILECSV);				//read and print the impact driver file data
			listTools.Items.Add(_newline);
		}

		public void ReadToolCSV(string filename)
		{
			var lines = File.ReadAllLines(filename);	//variable to hold csv lines
			var list = new List<Tool>();                //create list of Tool objects

			foreach (var line in lines)					//separate the values for each line
			{
				var values = line.Split(',');
				int qty = Convert.ToInt32(values[3]);       //convert the quantity to int then assign to another variable
				if (values.Length == 4)						//checks if each line has four values
				{
					var tool = new Tool()
					{
						ToolID = values[0],
						ToolManufacturer = values[1],
						ToolDescription = values[2],
						ToolQuantity = qty
					};
					list.Add(tool);
				} 
			}

			foreach (var item in list)					//print the file data
			{
				listTools.Items.Add(item);
			}
			listTools.Items.Add(_newline);
		}

		public void ReadOrdersCSV(string filename)
		{
			var lines = File.ReadAllLines(TOOLEVENTFILECSV);    //variable to hold csv lines
			var teventList = new List<ToolEvent>();				//create list of ToolEvent objects
			var empList = new List<Employee>();                 //create list of Employee objects
			var toolList = new List<Tool>();                    //create list of Tool objects


			foreach (var line in lines)
			{
				var values = line.Split(',');
				int trans = Convert.ToInt32(values[0]);
				int qty = Convert.ToInt32(values[5]);
				if (values.Length == 6)
				{
					var tevent = new ToolEvent()
					{
						TransactionNumber = trans,
						EmployeeID = values[1]
					};
					//var emp = new Employee()
					//{
					//	EmployeeID = values[1]
					//};
					//var tool = new Tool()
					//{
					//	ToolID = values[2],
					//	ToolManufacturer = values[3],
					//	ToolDescription = values[4],
					//	ToolQuantity = qty
					//};
				}
			}

			foreach (var item in teventList)                  //print the file data
			{
				listTools.Items.Add(item);
			}
			listTools.Items.Add(_newline);
		}

		private void btnClear_Click(object sender, EventArgs e)     //remove the checkmarks when the Clear button is clicked
		{
			chkBoxDrills.Checked = false;
			chkBoxImpactDriver.Checked = false;
			chkBoxAll.Checked = false;
			listTools.Items.Clear();
		}
		
		private void listTools_DoubleClick(object sender, EventArgs e)
		{
			btnCheckout_Click(sender, e);
		}

		private void btnSort_Click(object sender, EventArgs e)
		{
			
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnViewOrders_Click(object sender, EventArgs e)
		{
			//ReadOrdersCSV(TOOLEVENTFILECSV);
		}

		public void VerifyEmployeeID(string employeeID)
		{
			
		}
	}
}
