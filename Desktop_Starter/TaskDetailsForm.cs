using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_Starter
{
	public partial class TaskDetailsForm : Form
	{
		protected Models.DatabaseContext databasecontext = new Models.DatabaseContext();
		private Models.ViewModels.TaskViewModel postedTaskViewModel;
		public TaskDetailsForm(Models.ViewModels.TaskViewModel taskViewModel, Models.DatabaseContext postedDatabaseContext)
		{
			InitializeComponent();

			postedTaskViewModel = taskViewModel;
			databasecontext = postedDatabaseContext;

			nameTextBox.Text = taskViewModel.Name;
			descriptionTextBox.Text = taskViewModel.Description;

			switch (taskViewModel.TaskStatus.ToLower())
			{
				case "todo":
					ToDoRadioButton.Checked = true;
					break;

				case "done":
					DoneRadioButton.Checked = true;
					break;
			}

			if (postedTaskViewModel.EndtDate.HasValue)
			{
				endDateMaskedTextBox.Text = postedTaskViewModel.EndtDate.Value.ToString("dd/MM/yyyy HH:mm");
			}
		}

		private void EditButton_Click(object sender, EventArgs e)
		{
			var foundedEntity =
				databasecontext.Tasks
				.Where(current => current.Id == postedTaskViewModel.Id)
				.FirstOrDefault()
				;

			var taskStatus =
				databasecontext.TaskStatuses
				.ToList()
				;

			foundedEntity.Name = nameTextBox.Text;
			foundedEntity.Description = descriptionTextBox.Text;

			if (ToDoRadioButton.Checked == true)
			{
				foundedEntity.TaskStatus = taskStatus.Where(current => current.Titile.ToLower() == "ToDo".ToLower()).FirstOrDefault();
			}

			if (DoneRadioButton.Checked == true)
			{
				foundedEntity.TaskStatus = taskStatus.Where(current => current.Titile.ToLower() == "Done".ToLower()).FirstOrDefault();
			}

			//if (endDateMaskedTextBox.Text != string.Empty)
			//{
			//	foundedEntity.EndtDate = DateTime.TryParse(endDateMaskedTextBox.Text.ToString(),out foundedEntity.EndtDate);
			//}

			if (deactiveCheckBox.Checked == true)
			{
				foundedEntity.IsActive = false;
			}
			else
			{
				foundedEntity.IsActive = true;
			}


			databasecontext.SaveChanges();

			MessageBox.Show(text: "Edit Completed", caption: "", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);

			this.Close();
		}
	}
}
