﻿using LINQtoCSV;
using System;

namespace GBManufacturing
{
	[Serializable]
	public class Tool
	{
		protected string toolID;
		protected string toolManufacturer;
		protected string toolDescription;
		protected int toolQuantity;

		public Tool()
		{
			ToolID = "N/A";
			ToolManufacturer = "N/A";
			ToolDescription = "N/A";
			ToolQuantity = 0;
		}

		public Tool(string toolID, string toolManufacturer, string toolDescription, int toolQuantity)
		{
			ToolID = toolID;
			ToolManufacturer = toolManufacturer;
			ToolDescription = toolDescription;
			ToolQuantity = toolQuantity;
		}

		public override string ToString()
		{
			return "Tool ID: " + ToolID + ", Tool Manufacturer: " + ToolManufacturer + ", Tool Description: " 
				+ ToolDescription + ", Quantity: " + ToolQuantity.ToString();
		}

		[CsvColumn(Name = "Tool ID", FieldIndex = 1)]
		public string ToolID
		{
			get { return toolID; }
			set { toolID = value; }
		}

		[CsvColumn(Name = "Manufacturer", FieldIndex = 2)]
		public string ToolManufacturer
		{
			get { return toolManufacturer; }
			set { toolManufacturer = value; }
		}

		[CsvColumn(Name = "Description", FieldIndex = 3)]
		public string ToolDescription
		{
			get { return toolDescription; }
			set { toolDescription = value; }
		}

		[CsvColumn(Name = "Quantity", FieldIndex = 4)]
		public int ToolQuantity
		{
			get { return toolQuantity; }
			set { toolQuantity = value; }
		}
	}
}
