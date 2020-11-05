namespace Desktop_Starter
{
	partial class TaskDetailsForm
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
			this.statusGroupBox = new System.Windows.Forms.GroupBox();
			this.ToDoRadioButton = new System.Windows.Forms.RadioButton();
			this.DoneRadioButton = new System.Windows.Forms.RadioButton();
			this.taskStatusLabel = new System.Windows.Forms.Label();
			this.descriptionLabel = new System.Windows.Forms.Label();
			this.descriptionTextBox = new System.Windows.Forms.TextBox();
			this.editButton = new System.Windows.Forms.Button();
			this.nameTextBox = new System.Windows.Forms.TextBox();
			this.nameLabel = new System.Windows.Forms.Label();
			this.endDateMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
			this.endDateLabel = new System.Windows.Forms.Label();
			this.addTaskGroupBox.SuspendLayout();
			this.statusGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// addTaskGroupBox
			// 
			this.addTaskGroupBox.Controls.Add(this.endDateMaskedTextBox);
			this.addTaskGroupBox.Controls.Add(this.endDateLabel);
			this.addTaskGroupBox.Controls.Add(this.statusGroupBox);
			this.addTaskGroupBox.Controls.Add(this.taskStatusLabel);
			this.addTaskGroupBox.Controls.Add(this.descriptionLabel);
			this.addTaskGroupBox.Controls.Add(this.descriptionTextBox);
			this.addTaskGroupBox.Controls.Add(this.editButton);
			this.addTaskGroupBox.Controls.Add(this.nameTextBox);
			this.addTaskGroupBox.Controls.Add(this.nameLabel);
			this.addTaskGroupBox.Location = new System.Drawing.Point(12, 12);
			this.addTaskGroupBox.Name = "addTaskGroupBox";
			this.addTaskGroupBox.Size = new System.Drawing.Size(332, 254);
			this.addTaskGroupBox.TabIndex = 0;
			this.addTaskGroupBox.TabStop = false;
			this.addTaskGroupBox.Text = "Add Task";
			// 
			// statusGroupBox
			// 
			this.statusGroupBox.Controls.Add(this.ToDoRadioButton);
			this.statusGroupBox.Controls.Add(this.DoneRadioButton);
			this.statusGroupBox.Location = new System.Drawing.Point(72, 119);
			this.statusGroupBox.Name = "statusGroupBox";
			this.statusGroupBox.Size = new System.Drawing.Size(122, 44);
			this.statusGroupBox.TabIndex = 6;
			this.statusGroupBox.TabStop = false;
			// 
			// ToDoRadioButton
			// 
			this.ToDoRadioButton.AutoSize = true;
			this.ToDoRadioButton.Location = new System.Drawing.Point(6, 19);
			this.ToDoRadioButton.Name = "ToDoRadioButton";
			this.ToDoRadioButton.Size = new System.Drawing.Size(52, 17);
			this.ToDoRadioButton.TabIndex = 0;
			this.ToDoRadioButton.TabStop = true;
			this.ToDoRadioButton.Text = "ToDo";
			this.ToDoRadioButton.UseVisualStyleBackColor = true;
			// 
			// DoneRadioButton
			// 
			this.DoneRadioButton.AutoSize = true;
			this.DoneRadioButton.Location = new System.Drawing.Point(64, 19);
			this.DoneRadioButton.Name = "DoneRadioButton";
			this.DoneRadioButton.Size = new System.Drawing.Size(51, 17);
			this.DoneRadioButton.TabIndex = 1;
			this.DoneRadioButton.TabStop = true;
			this.DoneRadioButton.Text = "Done";
			this.DoneRadioButton.UseVisualStyleBackColor = true;
			// 
			// taskStatusLabel
			// 
			this.taskStatusLabel.AutoSize = true;
			this.taskStatusLabel.Location = new System.Drawing.Point(6, 140);
			this.taskStatusLabel.Name = "taskStatusLabel";
			this.taskStatusLabel.Size = new System.Drawing.Size(37, 13);
			this.taskStatusLabel.TabIndex = 4;
			this.taskStatusLabel.Text = "Status";
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
			this.descriptionTextBox.Size = new System.Drawing.Size(197, 49);
			this.descriptionTextBox.TabIndex = 3;
			// 
			// editButton
			// 
			this.editButton.Location = new System.Drawing.Point(72, 224);
			this.editButton.Name = "editButton";
			this.editButton.Size = new System.Drawing.Size(75, 23);
			this.editButton.TabIndex = 7;
			this.editButton.Text = "Edit";
			this.editButton.UseVisualStyleBackColor = true;
			this.editButton.Click += new System.EventHandler(this.EditButton_Click);
			// 
			// nameTextBox
			// 
			this.nameTextBox.Location = new System.Drawing.Point(72, 31);
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size(100, 20);
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
			// endDateMaskedTextBox
			// 
			this.endDateMaskedTextBox.Location = new System.Drawing.Point(72, 169);
			this.endDateMaskedTextBox.Mask = "00/00/0000 90:00";
			this.endDateMaskedTextBox.Name = "endDateMaskedTextBox";
			this.endDateMaskedTextBox.Size = new System.Drawing.Size(100, 20);
			this.endDateMaskedTextBox.TabIndex = 6;
			this.endDateMaskedTextBox.ValidatingType = typeof(System.DateTime);
			// 
			// endDateLabel
			// 
			this.endDateLabel.AutoSize = true;
			this.endDateLabel.Location = new System.Drawing.Point(6, 172);
			this.endDateLabel.Name = "endDateLabel";
			this.endDateLabel.Size = new System.Drawing.Size(49, 13);
			this.endDateLabel.TabIndex = 5;
			this.endDateLabel.Text = "EndDate";
			// 
			// TaskDetailsForm
			// 
			this.AcceptButton = this.editButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(354, 280);
			this.Controls.Add(this.addTaskGroupBox);
			this.Name = "TaskDetailsForm";
			this.Text = "TaskDetailsForm";
			this.addTaskGroupBox.ResumeLayout(false);
			this.addTaskGroupBox.PerformLayout();
			this.statusGroupBox.ResumeLayout(false);
			this.statusGroupBox.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox addTaskGroupBox;
		private System.Windows.Forms.Label descriptionLabel;
		private System.Windows.Forms.TextBox descriptionTextBox;
		private System.Windows.Forms.Button editButton;
		private System.Windows.Forms.TextBox nameTextBox;
		private System.Windows.Forms.Label nameLabel;
		private System.Windows.Forms.Label taskStatusLabel;
		private System.Windows.Forms.GroupBox statusGroupBox;
		private System.Windows.Forms.RadioButton ToDoRadioButton;
		private System.Windows.Forms.RadioButton DoneRadioButton;
		private System.Windows.Forms.MaskedTextBox endDateMaskedTextBox;
		private System.Windows.Forms.Label endDateLabel;
	}
}