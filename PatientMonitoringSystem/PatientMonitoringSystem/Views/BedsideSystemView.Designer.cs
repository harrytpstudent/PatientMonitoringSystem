﻿namespace PatientMonitoringSystem.Views
{
	partial class BedsideSystemView
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
            this.components = new System.ComponentModel.Container();
            this.Updater = new System.Windows.Forms.Timer(this.components);
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.Table = new System.Windows.Forms.TableLayoutPanel();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.ModuleCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NameEntry = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.BottomPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Updater
            // 
            this.Updater.Enabled = true;
            this.Updater.Interval = 1000;
            this.Updater.Tick += new System.EventHandler(this.Updater_Tick);
            // 
            // BottomPanel
            // 
            this.BottomPanel.AutoSize = true;
            this.BottomPanel.Controls.Add(this.Table);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomPanel.Margin = new System.Windows.Forms.Padding(2);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(717, 0);
            this.BottomPanel.TabIndex = 2;
            // 
            // Table
            // 
            this.Table.AutoSize = true;
            this.Table.ColumnCount = 1;
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Table.Location = new System.Drawing.Point(0, 0);
            this.Table.Margin = new System.Windows.Forms.Padding(2);
            this.Table.Name = "Table";
            this.Table.RowCount = 1;
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Table.Size = new System.Drawing.Size(717, 0);
            this.Table.TabIndex = 0;
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.label2);
            this.TopPanel.Controls.Add(this.ModuleCombo);
            this.TopPanel.Controls.Add(this.label1);
            this.TopPanel.Controls.Add(this.NameEntry);
            this.TopPanel.Controls.Add(this.AddButton);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Margin = new System.Windows.Forms.Padding(2);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(717, 52);
            this.TopPanel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Module Type:";
            // 
            // ModuleCombo
            // 
            this.ModuleCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModuleCombo.FormattingEnabled = true;
            this.ModuleCombo.Items.AddRange(new object[] {
            "Blood Pressure",
            "Oxygen Level"});
            this.ModuleCombo.Location = new System.Drawing.Point(318, 15);
            this.ModuleCombo.Name = "ModuleCombo";
            this.ModuleCombo.Size = new System.Drawing.Size(121, 21);
            this.ModuleCombo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // NameEntry
            // 
            this.NameEntry.Location = new System.Drawing.Point(72, 16);
            this.NameEntry.Margin = new System.Windows.Forms.Padding(2);
            this.NameEntry.Name = "NameEntry";
            this.NameEntry.Size = new System.Drawing.Size(107, 20);
            this.NameEntry.TabIndex = 3;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(599, 6);
            this.AddButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(100, 40);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Add";
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // BedsideSystemView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.TopPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BedsideSystemView";
            this.Size = new System.Drawing.Size(717, 52);
            this.Load += new System.EventHandler(this.BedsideSystemView_Load);
            this.BottomPanel.ResumeLayout(false);
            this.BottomPanel.PerformLayout();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Timer Updater;
		private System.Windows.Forms.Panel BottomPanel;
		private System.Windows.Forms.Panel TopPanel;
		private System.Windows.Forms.TableLayoutPanel Table;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox NameEntry;
		private System.Windows.Forms.Button AddButton;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox ModuleCombo;
	}
}

