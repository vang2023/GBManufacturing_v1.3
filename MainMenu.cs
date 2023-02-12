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
			CheckoutForm checkoutInput = new CheckoutForm();     //new checkout form object

			using (checkoutInput)
			{
				int itemSelected = listTools.SelectedIndex; //for list item selected

				if (itemSelected < 0)
				{
					MessageBox.Show("Please select a tool.");
					return;
				}

				//Tool tselected = (Tool)listTools.Items[itemSelected];
				//checkoutInput.txtToolID.Text = "fjaoi;uwoefij";
				//checkoutInput.txtToolManufacturer.Text = "fjawoentmy,ufij";
				//checkoutInput.txtToolDescription.Text = "fjaw4343yoefij";
				//checkoutInput.txtQuantity.Text = "fjawoafwefwaefefij";

				//checkoutInput.txtToolID.Text = toolSelected.ToolID;
				//checkoutInput.txtToolManufacturer.Text = toolSelected.ToolManufacturer;
				//checkoutInput.txtToolDescription.Text = toolSelected.ToolManufacturer;
				//checkoutInput.txtQuantity.Text = toolSelected.ToolQuantity;

				MessageBox.Show(checkoutInput.txtToolID.Text);

				//-------------------READ tool_event.csv TO CHECK FOR DUPLICATE TRANSACTION NUMBERS-------------------//
				//var transactionNumbers = new List<int>();

				//string[] csvLines = System.IO.File.ReadAllLines(TOOLEVENTCSV);  //string array to read each line

				//for (int i = 0; i < csvLines.Length; i++)
				//{
				//	string[] rowData = csvLines[i].Split(',');  //split the csv data by comma
				//	if (rowData.Length == 5)                    //if the row is equal to 5 values, then add the data
				//	{
				//		int t = Convert.ToInt32(rowData[0]);    //convert to int before adding
				//		transactionNumbers.Add(t);              //add transaction number to element
				//	}
				//}

				


				//write to tool event csv file
				//File.AppendAllText(TOOLEVENTCSV, $"{newTransactionNumber},{empid},{toolid},{toolmanufacturer},{tooldescription},{qty}\n");
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
				int qty = Convert.ToInt32(values[3]);		//convert the quantity to int then assign to another variable
				var tool = new Tool() { ToolID = values[0], ToolManufacturer = values[1],
					ToolDescription = values[2], ToolQuantity = qty};
				list.Add(tool);
			}

			foreach (var item in list)					//print the file data
			{
				listTools.Items.Add(item);
			}

			listTools.Items.Add(_newline);
		}

		

		public void AppendCSV(string filename)
		{

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
			//listbox item is assigned to Tool object
			Tool toolSelected = (Tool)listTools.SelectedItem;

			//create instance of second form
			CheckoutForm checkoutForm = new CheckoutForm();

			//generate a random number for the TRANSACTION and output in textbox
			Random randomNumber = new Random();                 
			int newTransactionNumber = randomNumber.Next(100000, 1000000);

			//convert then add the EMPLOYEE ID FROM THE EMP TEXTBOX
			string empid = checkoutForm.txtEmployeeID.Text;

			










			//send data from checkoutForm's textboxes to public ToolEvent attributes
			checkoutForm.Transaction = newTransactionNumber;
			checkoutForm.EmployeeID = empid.ToString();
			checkoutForm.ToolID = toolSelected.ToolID;
			checkoutForm.Manufacturer = toolSelected.ToolManufacturer;
			checkoutForm.Description= toolSelected.ToolDescription;
			checkoutForm.Quantity = toolSelected.ToolQuantity;			

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

			//string toolid = checkoutForm.ToolID;                //create strings for employee ID and tool info
			//string manufacturer = checkoutForm.Manufacturer;
			//string description = checkoutForm.Description;
			//int quantity = checkoutForm.Quantity;

			//ToolEvent toolEvent = new ToolEvent(newTransactionNumber, empid, toolid, manufacturer, description, quantity);
		}

		private void btnSort_Click(object sender, EventArgs e)
		{

		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
