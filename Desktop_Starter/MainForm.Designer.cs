namespace Desktop_Starter
{
	partial class MainForm
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
            this.addTaskGroupBox = new System.Windows.Forms.GroupBox();
            this.isShowDeactiveCheckBox = new System.Windows.Forms.CheckBox();
            this.startDateMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.taskDataGridView = new System.Windows.Forms.DataGridView();
            this.addTaskGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addTaskGroupBox
            // 
            this.addTaskGroupBox.Controls.Add(this.isShowDeactiveCheckBox);
            this.addTaskGroupBox.Controls.Add(this.startDateMaskedTextBox);
            this.addTaskGroupBox.Controls.Add(this.startDateLabel);
            this.addTaskGroupBox.Controls.Add(this.descriptionLabel);
            this.addTaskGroupBox.Controls.Add(this.descriptionTextBox);
            this.addTaskGroupBox.Controls.Add(this.saveButton);
            this.addTaskGroupBox.Controls.Add(this.nameTextBox);
            this.addTaskGroupBox.Controls.Add(this.nameLabel);
            this.addTaskGroupBox.Location = new System.Drawing.Point(12, 12);
            this.addTaskGroupBox.Name = "addTaskGroupBox";
            this.addTaskGroupBox.Size = new System.Drawing.Size(632, 198);
            this.addTaskGroupBox.TabIndex = 0;
            this.addTaskGroupBox.TabStop = false;
            this.addTaskGroupBox.Text = "Add Task";
            // 
            // isShowDeactiveCheckBox
            // 
            this.isShowDeactiveCheckBox.AutoSize = true;
            this.isShowDeactiveCheckBox.Location = new System.Drawing.Point(153, 173);
            this.isShowDeactiveCheckBox.Name = "isShowDeactiveCheckBox";
            this.isShowDeactiveCheckBox.Size = new System.Drawing.Size(104, 17);
            this.isShowDeactiveCheckBox.TabIndex = 7;
            this.isShowDeactiveCheckBox.Text = "Show Deactives";
            this.isShowDeactiveCheckBox.UseVisualStyleBackColor = true;
            this.isShowDeactiveCheckBox.CheckedChanged += new System.EventHandler(this.isShowDeactiveCheckBox_CheckedChanged);
            // 
            // startDateMaskedTextBox
            // 
            this.startDateMaskedTextBox.Location = new System.Drawing.Point(72, 143);
            this.startDateMaskedTextBox.Mask = "00/00/0000 90:00";
            this.startDateMaskedTextBox.Name = "startDateMaskedTextBox";
            this.startDateMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.startDateMaskedTextBox.TabIndex = 5;
            this.startDateMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(6, 146);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(52, 13);
            this.startDateLabel.TabIndex = 4;
            this.startDateLabel.Text = "StartDate";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(6, 67);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.descriptionLabel.TabIndex = 2;
            this.descriptionLabel.Text = "Description";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(72, 64);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(197, 73);
            this.descriptionTextBox.TabIndex = 3;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(72, 169);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(72, 31);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(197, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(6, 34);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // taskDataGridView
            // 
            this.taskDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.taskDataGridView.Location = new System.Drawing.Point(12, 216);
            this.taskDataGridView.Name = "taskDataGridView";
            this.taskDataGridView.Size = new System.Drawing.Size(632, 221);
            this.taskDataGridView.TabIndex = 0;
            this.taskDataGridView.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.taskDataGridView_RowsRemoved);
            this.taskDataGridView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TaskDataGridView_MouseDoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 447);
            this.Controls.Add(this.taskDataGridView);
            this.Controls.Add(this.addTaskGroupBox);
            this.Name = "MainForm";
            this.Text = "Task";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.addTaskGroupBox.ResumeLayout(false);
            this.addTaskGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskDataGridView)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox addTaskGroupBox;
		private System.Windows.Forms.TextBox nameTextBox;
		private System.Windows.Forms.Label nameLabel;
		private System.Windows.Forms.DataGridView taskDataGridView;
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.Label descriptionLabel;
		private System.Windows.Forms.TextBox descriptionTextBox;
		private System.Windows.Forms.MaskedTextBox startDateMaskedTextBox;
		private System.Windows.Forms.Label startDateLabel;
		private System.Windows.Forms.CheckBox isShowDeactiveCheckBox;
	}
}

