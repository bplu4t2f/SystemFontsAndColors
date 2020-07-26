namespace SystemFontsAndColors
{
	partial class Form1
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.flowLayoutPanelFonts = new System.Windows.Forms.FlowLayoutPanel();
			this.flowLayoutPanelColors = new System.Windows.Forms.FlowLayoutPanel();
			this.labelFontsHeading = new System.Windows.Forms.Label();
			this.labelColorsHeading = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPageSystemFontsAndSystemColors = new System.Windows.Forms.TabPage();
			this.tabPageSystemInformation = new System.Windows.Forms.TabPage();
			this.flowLayoutPanelSystemInformation = new System.Windows.Forms.FlowLayoutPanel();
			this.tableLayoutPanel1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPageSystemFontsAndSystemColors.SuspendLayout();
			this.tabPageSystemInformation.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanelFonts, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanelColors, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.labelFontsHeading, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.labelColorsHeading, 1, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(786, 418);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// flowLayoutPanelFonts
			// 
			this.flowLayoutPanelFonts.AutoScroll = true;
			this.flowLayoutPanelFonts.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanelFonts.Location = new System.Drawing.Point(3, 26);
			this.flowLayoutPanelFonts.Name = "flowLayoutPanelFonts";
			this.flowLayoutPanelFonts.Size = new System.Drawing.Size(387, 389);
			this.flowLayoutPanelFonts.TabIndex = 0;
			// 
			// flowLayoutPanelColors
			// 
			this.flowLayoutPanelColors.AutoScroll = true;
			this.flowLayoutPanelColors.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanelColors.Location = new System.Drawing.Point(396, 26);
			this.flowLayoutPanelColors.Name = "flowLayoutPanelColors";
			this.flowLayoutPanelColors.Size = new System.Drawing.Size(387, 389);
			this.flowLayoutPanelColors.TabIndex = 1;
			// 
			// labelFontsHeading
			// 
			this.labelFontsHeading.BackColor = System.Drawing.Color.Gray;
			this.labelFontsHeading.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelFontsHeading.ForeColor = System.Drawing.Color.White;
			this.labelFontsHeading.Location = new System.Drawing.Point(3, 0);
			this.labelFontsHeading.Name = "labelFontsHeading";
			this.labelFontsHeading.Size = new System.Drawing.Size(387, 23);
			this.labelFontsHeading.TabIndex = 2;
			this.labelFontsHeading.Text = "SystemFonts";
			this.labelFontsHeading.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelColorsHeading
			// 
			this.labelColorsHeading.BackColor = System.Drawing.Color.Gray;
			this.labelColorsHeading.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelColorsHeading.ForeColor = System.Drawing.Color.White;
			this.labelColorsHeading.Location = new System.Drawing.Point(396, 0);
			this.labelColorsHeading.Name = "labelColorsHeading";
			this.labelColorsHeading.Size = new System.Drawing.Size(387, 23);
			this.labelColorsHeading.TabIndex = 3;
			this.labelColorsHeading.Text = "SystemColors";
			this.labelColorsHeading.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPageSystemFontsAndSystemColors);
			this.tabControl1.Controls.Add(this.tabPageSystemInformation);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(800, 450);
			this.tabControl1.TabIndex = 1;
			// 
			// tabPageSystemFontsAndSystemColors
			// 
			this.tabPageSystemFontsAndSystemColors.Controls.Add(this.tableLayoutPanel1);
			this.tabPageSystemFontsAndSystemColors.Location = new System.Drawing.Point(4, 22);
			this.tabPageSystemFontsAndSystemColors.Name = "tabPageSystemFontsAndSystemColors";
			this.tabPageSystemFontsAndSystemColors.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageSystemFontsAndSystemColors.Size = new System.Drawing.Size(792, 424);
			this.tabPageSystemFontsAndSystemColors.TabIndex = 0;
			this.tabPageSystemFontsAndSystemColors.Text = "SystemFonts and SystemColors";
			this.tabPageSystemFontsAndSystemColors.UseVisualStyleBackColor = true;
			// 
			// tabPageSystemInformation
			// 
			this.tabPageSystemInformation.Controls.Add(this.flowLayoutPanelSystemInformation);
			this.tabPageSystemInformation.Location = new System.Drawing.Point(4, 22);
			this.tabPageSystemInformation.Name = "tabPageSystemInformation";
			this.tabPageSystemInformation.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageSystemInformation.Size = new System.Drawing.Size(792, 424);
			this.tabPageSystemInformation.TabIndex = 1;
			this.tabPageSystemInformation.Text = "SystemInformation";
			this.tabPageSystemInformation.UseVisualStyleBackColor = true;
			// 
			// flowLayoutPanelSystemInformation
			// 
			this.flowLayoutPanelSystemInformation.AutoScroll = true;
			this.flowLayoutPanelSystemInformation.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanelSystemInformation.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flowLayoutPanelSystemInformation.Location = new System.Drawing.Point(3, 3);
			this.flowLayoutPanelSystemInformation.Name = "flowLayoutPanelSystemInformation";
			this.flowLayoutPanelSystemInformation.Size = new System.Drawing.Size(786, 418);
			this.flowLayoutPanelSystemInformation.TabIndex = 0;
			this.flowLayoutPanelSystemInformation.WrapContents = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tabControl1);
			this.Name = "Form1";
			this.Text = "SystemFontsAndColors";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tabPageSystemFontsAndSystemColors.ResumeLayout(false);
			this.tabPageSystemInformation.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelFonts;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelColors;
		private System.Windows.Forms.Label labelFontsHeading;
		private System.Windows.Forms.Label labelColorsHeading;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPageSystemFontsAndSystemColors;
		private System.Windows.Forms.TabPage tabPageSystemInformation;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSystemInformation;
	}
}

