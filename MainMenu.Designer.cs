
namespace GBManufacturing
{
	partial class MainMenu
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.listTools = new System.Windows.Forms.ListBox();
			this.btnCheckout = new System.Windows.Forms.Button();
			this.btnReturn = new System.Windows.Forms.Button();
			this.btnOrder = new System.Windows.Forms.Button();
			this.btnShip = new System.Windows.Forms.Button();
			this.lblCompany = new System.Windows.Forms.Label();
			this.toolLbl = new System.Windows.Forms.Label();
			this.chkBoxAll = new System.Windows.Forms.CheckBox();
			this.chkBoxImpactDriver = new System.Windows.Forms.CheckBox();
			this.chkBoxDrills = new System.Windows.Forms.CheckBox();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnSort = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// listTools
			// 
			this.listTools.HorizontalScrollbar = true;
			this.listTools.Location = new System.Drawing.Point(452, 12);
			this.listTools.Name = "listTools";
			this.listTools.Size = new System.Drawing.Size(620, 576);
			this.listTools.TabIndex = 18;
			this.listTools.DoubleClick += new System.EventHandler(this.listTools_DoubleClick);
			// 
			// btnCheckout
			// 
			this.btnCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCheckout.Location = new System.Drawing.Point(17, 66);
			this.btnCheckout.Name = "btnCheckout";
			this.btnCheckout.Size = new System.Drawing.Size(120, 70);
			this.btnCheckout.TabIndex = 1;
			this.btnCheckout.Text = "Tool Checkout";
			this.btnCheckout.UseVisualStyleBackColor = true;
			this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
			// 
			// btnReturn
			// 
			this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReturn.Location = new System.Drawing.Point(17, 142);
			this.btnReturn.Name = "btnReturn";
			this.btnReturn.Size = new System.Drawing.Size(120, 70);
			this.btnReturn.TabIndex = 2;
			this.btnReturn.Text = "Tool Return";
			this.btnReturn.UseVisualStyleBackColor = true;
			this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
			// 
			// btnOrder
			// 
			this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOrder.Location = new System.Drawing.Point(143, 66);
			this.btnOrder.Name = "btnOrder";
			this.btnOrder.Size = new System.Drawing.Size(120, 70);
			this.btnOrder.TabIndex = 4;
			this.btnOrder.Text = "Tool Order";
			this.btnOrder.UseVisualStyleBackColor = true;
			this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
			// 
			// btnShip
			// 
			this.btnShip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnShip.Location = new System.Drawing.Point(143, 142);
			this.btnShip.Name = "btnShip";
			this.btnShip.Size = new System.Drawing.Size(120, 70);
			this.btnShip.TabIndex = 5;
			this.btnShip.Text = "Tool Ship";
			this.btnShip.UseVisualStyleBackColor = true;
			this.btnShip.Click += new System.EventHandler(this.btnShip_Click);
			// 
			// lblCompany
			// 
			this.lblCompany.AutoSize = true;
			this.lblCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCompany.Location = new System.Drawing.Point(12, 9);
			this.lblCompany.Name = "lblCompany";
			this.lblCompany.Size = new System.Drawing.Size(338, 25);
			this.lblCompany.TabIndex = 6;
			this.lblCompany.Text = "GB Manufacturing Tool System";
			// 
			// toolLbl
			// 
			this.toolLbl.AutoSize = true;
			this.toolLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toolLbl.Location = new System.Drawing.Point(12, 333);
			this.toolLbl.Name = "toolLbl";
			this.toolLbl.Size = new System.Drawing.Size(149, 25);
			this.toolLbl.TabIndex = 9;
			this.toolLbl.Text = "Tool Selection";
			// 
			// chkBoxAll
			// 
			this.chkBoxAll.AutoSize = true;
			this.chkBoxAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkBoxAll.Location = new System.Drawing.Point(40, 429);
			this.chkBoxAll.Name = "chkBoxAll";
			this.chkBoxAll.Size = new System.Drawing.Size(50, 28);
			this.chkBoxAll.TabIndex = 13;
			this.chkBoxAll.Text = "All";
			this.chkBoxAll.UseVisualStyleBackColor = true;
			this.chkBoxAll.CheckedChanged += new System.EventHandler(this.chkBoxAll_CheckedChanged);
			// 
			// chkBoxImpactDriver
			// 
			this.chkBoxImpactDriver.AutoSize = true;
			this.chkBoxImpactDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkBoxImpactDriver.Location = new System.Drawing.Point(40, 395);
			this.chkBoxImpactDriver.Name = "chkBoxImpactDriver";
			this.chkBoxImpactDriver.Size = new System.Drawing.Size(147, 28);
			this.chkBoxImpactDriver.TabIndex = 11;
			this.chkBoxImpactDriver.Text = "Impact Drivers";
			this.chkBoxImpactDriver.UseVisualStyleBackColor = true;
			this.chkBoxImpactDriver.CheckedChanged += new System.EventHandler(this.chkBoxImpactDriver_CheckedChanged);
			// 
			// chkBoxDrills
			// 
			this.chkBoxDrills.AutoSize = true;
			this.chkBoxDrills.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkBoxDrills.Location = new System.Drawing.Point(40, 361);
			this.chkBoxDrills.Name = "chkBoxDrills";
			this.chkBoxDrills.Size = new System.Drawing.Size(69, 28);
			this.chkBoxDrills.TabIndex = 10;
			this.chkBoxDrills.Text = "Drills";
			this.chkBoxDrills.UseVisualStyleBackColor = true;
			this.chkBoxDrills.CheckedChanged += new System.EventHandler(this.chkBoxDrills_CheckedChanged);
			// 
			// btnClear
			// 
			this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClear.Location = new System.Drawing.Point(143, 481);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(120, 30);
			this.btnClear.TabIndex = 15;
			this.btnClear.Text = "Clear Screen";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnSort
			// 
			this.btnSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSort.Location = new System.Drawing.Point(17, 481);
			this.btnSort.Name = "btnSort";
			this.btnSort.Size = new System.Drawing.Size(120, 30);
			this.btnSort.TabIndex = 16;
			this.btnSort.Text = "Sort List";
			this.btnSort.UseVisualStyleBackColor = true;
			this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
			// 
			// btnExit
			// 
			this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExit.Location = new System.Drawing.Point(17, 545);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(120, 30);
			this.btnExit.TabIndex = 17;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// MainMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1084, 621);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnSort);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.chkBoxAll);
			this.Controls.Add(this.chkBoxImpactDriver);
			this.Controls.Add(this.chkBoxDrills);
			this.Controls.Add(this.toolLbl);
			this.Controls.Add(this.lblCompany);
			this.Controls.Add(this.btnShip);
			this.Controls.Add(this.btnOrder);
			this.Controls.Add(this.btnReturn);
			this.Controls.Add(this.btnCheckout);
			this.Controls.Add(this.listTools);
			this.Name = "MainMenu";
			this.Text = "Main Menu";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox listTools;
		private System.Windows.Forms.Button btnCheckout;
		private System.Windows.Forms.Button btnReturn;
		private System.Windows.Forms.Button btnOrder;
		private System.Windows.Forms.Button btnShip;
		private System.Windows.Forms.Label lblCompany;
		private System.Windows.Forms.Label toolLbl;
		private System.Windows.Forms.CheckBox chkBoxAll;
		private System.Windows.Forms.CheckBox chkBoxImpactDriver;
		private System.Windows.Forms.CheckBox chkBoxDrills;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnSort;
		private System.Windows.Forms.Button btnExit;
	}
}

