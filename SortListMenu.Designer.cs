
namespace GBManufacturing
{
	partial class SortListMenu
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
			this.lblSortListMenu = new System.Windows.Forms.Label();
			this.radioBtnID = new System.Windows.Forms.RadioButton();
			this.radioBtnManufacturer = new System.Windows.Forms.RadioButton();
			this.radioBtnDescription = new System.Windows.Forms.RadioButton();
			this.radioBtnQuantity = new System.Windows.Forms.RadioButton();
			this.SuspendLayout();
			// 
			// lblSortListMenu
			// 
			this.lblSortListMenu.AutoSize = true;
			this.lblSortListMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSortListMenu.Location = new System.Drawing.Point(13, 13);
			this.lblSortListMenu.Name = "lblSortListMenu";
			this.lblSortListMenu.Size = new System.Drawing.Size(73, 24);
			this.lblSortListMenu.TabIndex = 0;
			this.lblSortListMenu.Text = "Sort by:";
			// 
			// radioBtnID
			// 
			this.radioBtnID.AutoSize = true;
			this.radioBtnID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioBtnID.Location = new System.Drawing.Point(17, 63);
			this.radioBtnID.Name = "radioBtnID";
			this.radioBtnID.Size = new System.Drawing.Size(78, 24);
			this.radioBtnID.TabIndex = 1;
			this.radioBtnID.TabStop = true;
			this.radioBtnID.Text = "Tool ID";
			this.radioBtnID.UseVisualStyleBackColor = true;
			this.radioBtnID.CheckedChanged += new System.EventHandler(this.radioBtnID_CheckedChanged);
			// 
			// radioBtnManufacturer
			// 
			this.radioBtnManufacturer.AutoSize = true;
			this.radioBtnManufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioBtnManufacturer.Location = new System.Drawing.Point(17, 93);
			this.radioBtnManufacturer.Name = "radioBtnManufacturer";
			this.radioBtnManufacturer.Size = new System.Drawing.Size(122, 24);
			this.radioBtnManufacturer.TabIndex = 2;
			this.radioBtnManufacturer.TabStop = true;
			this.radioBtnManufacturer.Text = "Manufacturer";
			this.radioBtnManufacturer.UseVisualStyleBackColor = true;
			this.radioBtnManufacturer.CheckedChanged += new System.EventHandler(this.radioBtnManufacturer_CheckedChanged);
			// 
			// radioBtnDescription
			// 
			this.radioBtnDescription.AutoSize = true;
			this.radioBtnDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioBtnDescription.Location = new System.Drawing.Point(17, 123);
			this.radioBtnDescription.Name = "radioBtnDescription";
			this.radioBtnDescription.Size = new System.Drawing.Size(107, 24);
			this.radioBtnDescription.TabIndex = 3;
			this.radioBtnDescription.TabStop = true;
			this.radioBtnDescription.Text = "Description";
			this.radioBtnDescription.UseVisualStyleBackColor = true;
			this.radioBtnDescription.CheckedChanged += new System.EventHandler(this.radioBtnDescription_CheckedChanged);
			// 
			// radioBtnQuantity
			// 
			this.radioBtnQuantity.AutoSize = true;
			this.radioBtnQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioBtnQuantity.Location = new System.Drawing.Point(17, 153);
			this.radioBtnQuantity.Name = "radioBtnQuantity";
			this.radioBtnQuantity.Size = new System.Drawing.Size(86, 24);
			this.radioBtnQuantity.TabIndex = 4;
			this.radioBtnQuantity.TabStop = true;
			this.radioBtnQuantity.Text = "Quantity";
			this.radioBtnQuantity.UseVisualStyleBackColor = true;
			this.radioBtnQuantity.CheckedChanged += new System.EventHandler(this.radioBtnQuantity_CheckedChanged);
			// 
			// SortListMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.radioBtnQuantity);
			this.Controls.Add(this.radioBtnDescription);
			this.Controls.Add(this.radioBtnManufacturer);
			this.Controls.Add(this.radioBtnID);
			this.Controls.Add(this.lblSortListMenu);
			this.Name = "SortListMenu";
			this.Text = "Sort List";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblSortListMenu;
		private System.Windows.Forms.RadioButton radioBtnID;
		private System.Windows.Forms.RadioButton radioBtnManufacturer;
		private System.Windows.Forms.RadioButton radioBtnDescription;
		private System.Windows.Forms.RadioButton radioBtnQuantity;
	}
}