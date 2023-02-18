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
			// listbox item is assigned to Tool object
			Tool toolSelected = (Tool)listTools.SelectedItem;

			// create instance of second form
			CheckoutForm checkoutForm = new CheckoutForm();

			// generate a random number for the TRANSACTION and output in textbox
			Random randomNumber = new Random();
			int newTransactionNumber = randomNumber.Next(100000, 1000000);

			string empid = checkoutForm.txtEmployeeID.Text;     // convert then add the EMPLOYEE ID FROM THE EMPLOYEE TEXTBOX
			string toolid = checkoutForm.ToolID;                // create the rest of the variables for checkout info
			string manufacturer = checkoutForm.Manufacturer;
			string description = checkoutForm.Description;
			int quantity = checkoutForm.Quantity;

			if (toolSelected != null)	// make sure item is selected
			{
				// send data from checkoutForm's textboxes to ToolEvent attributes
				checkoutForm.Transaction = newTransactionNumber;
				checkoutForm.EmployeeID = empid;
				checkoutForm.ToolID = toolSelected.ToolID;
				checkoutForm.Manufacturer = toolSelected.ToolManufacturer;
				checkoutForm.Description = toolSelected.ToolDescription;
				checkoutForm.Quantity = toolSelected.ToolQuantity;
			}
			
			// display the checkout form
			DialogResult result = checkoutForm.ShowDialog();

			// if the checkout form is successful, assign data in textboxes to the Tool object
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
			// ONLY REMOVES THE ITEM FROM LISTBOX, NOT FROM THE ACTUAL RECORD
			int itemNumber = listTools.SelectedIndex;

			if (itemNumber > -1)
			{
				listTools.Items.RemoveAt(itemNumber);
			}
		}

		private void btnShip_Click(object sender, EventArgs e)
		{

		}

		private void chkBoxDrills_CheckedChanged(object sender, EventArgs e)
		{
			if (chkBoxDrills.Checked)	// if checked, the Drills data file displays to the listbox
			{
				ReadToolCSV(DRILLFILECSV);	// read the Drill file
			}
		}

		private void chkBoxImpactDriver_CheckedChanged(object sender, EventArgs e)
		{
			if (chkBoxImpactDriver.Checked) // if checked, the Impact Driver data file displays to the listbox
			{
				ReadToolCSV(IMPACTDRIVERFILECSV);	// read the Impact Driver file
			}
		}

		private void chkBoxAll_CheckedChanged(object sender, EventArgs e)
		{
			ReadToolCSV(DRILLFILECSV);		// if checked, read and print the Drill and Impact Driver files
			listTools.Items.Add(_newline);
			ReadToolCSV(IMPACTDRIVERFILECSV);
			listTools.Items.Add(_newline);
		}

		public void ReadToolCSV(string filename)
		{
			var lines = File.ReadAllLines(filename);	// variable to hold csv lines
			var list = new List<Tool>();                // create list of Tool objects

			foreach (var line in lines)					// iterate through the file and add each line to Tool list
			{
				var values = line.Split(',');               // separate the values for each line
				int qty = Convert.ToInt32(values[3]);       // convert the quantity to int then assign to another variable
				if (values.Length == 4)						// checks if each line has four values
				{
					var tool = new Tool()					// assign Tool attributes to Tool object
					{
						ToolID = values[0],
						ToolManufacturer = values[1],
						ToolDescription = values[2],
						ToolQuantity = qty
					};
					list.Add(tool);			// add the object to the Tool list
				} 
			}

			foreach (var item in list)		// print the file data to listbox
			{
				listTools.Items.Add(item);
			}
			listTools.Items.Add(_newline);
		}

		public void ReadOrdersCSV(string filename)
		{
			var lines = File.ReadAllLines(TOOLEVENTFILECSV);	// variable to hold csv lines
			var toolEventList = new List<ToolEvent>();			// create list of ToolEvent objects

			foreach (var line in lines)				// iterate through the file and add each line to the ToolEvent list
			{
				var values = line.Split(',');		// separate the csv values by comma

				int transNum = 0;					// create variables to hold the Tool Order values
				string empID = " ";
				string toolID = " ";
				string toolManufacturer;
				string toolDescription;
				int qty;

				if (values.Length == 6)		// if the line holds 6 values, then assign to ToolEvent object
				{
					transNum = Convert.ToInt32(values[0]);	// convert the transaction to int
					empID = values[1];						// assign the rest of the Tool Event values
					toolID = values[2];
					toolManufacturer = values[3];
					toolDescription = values[4];
					qty = Convert.ToInt32(values[5]);

					Employee employee = new Employee(empID, "N/A", "N/A");	// create Employee object and pass values
					Tool tool = new Tool(toolID, toolManufacturer, toolDescription, qty);	// create Tool object and pass values
					ToolEvent toolEvent = new ToolEvent(transNum, employee, tool);  // create ToolEvent object and pass values
					toolEventList.Add(toolEvent);				// add the object to the toolEventList list
				}
			}

			foreach (var item in toolEventList)		// print the file data
			{
				listTools.Items.Add(item);
			}
			listTools.Items.Add(_newline);
		}

		private void btnClear_Click(object sender, EventArgs e)     // remove the checkmarks when the Clear button is clicked
		{
			chkBoxDrills.Checked = false;
			chkBoxImpactDriver.Checked = false;
			chkBoxAll.Checked = false;
			listTools.Items.Clear();
		}
		
		private void listTools_DoubleClick(object sender, EventArgs e)
		{
			btnCheckout_Click(sender, e);	// double-click and item has same effect as Checkout button
		}

		private void btnSort_Click(object sender, EventArgs e)
		{
			
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();		// exit the application
		}

		private void btnViewOrders_Click(object sender, EventArgs e)
		{
			ReadOrdersCSV(TOOLEVENTFILECSV);	// read the Tool Event file
		}
	}
}
