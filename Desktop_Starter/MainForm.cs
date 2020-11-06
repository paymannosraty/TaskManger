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
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		protected Models.DatabaseContext databaseContext;

		private void MainForm_Load(object sender, EventArgs e)
		{
			LoadTasks(isShowDeactive: false);
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(nameTextBox.Text) == true)
			{
				return;
			}
			var toDoTaskStatus =
					databaseContext.TaskStatuses
					.Where(current => current.Titile.ToLower() == "ToDo".ToLower())
					.FirstOrDefault()
					;

			Models.Task task = new Models.Task()
			{
				Name = nameTextBox.Text.ToString(),

				TaskStatus = toDoTaskStatus,

				Description = descriptionTextBox.Text.ToString(),

				StartDate = 
					DateTime.TryParse(startDateMaskedTextBox.Text.ToString(), out DateTime dateTime) == true ? dateTime : DateTime.Now,

				IsActive = true,
			};

			databaseContext.Tasks.Add(task);

			databaseContext.SaveChanges();

			RefreshTaskDataGridView();

			ResetValues();
		}

		private void RefreshTaskDataGridView()
		{
			LoadTasks(isShowDeactive: false);
			taskDataGridView.Update();
			taskDataGridView.Refresh();
		}

		private void LoadTasks(bool isShowDeactive)
		{
			databaseContext = new Models.DatabaseContext();

			bool hasTask =
				databaseContext.Tasks
				.Any();

			List<Models.Task> tasks = new List<Models.Task>();

			if (hasTask == true)
			{
				if (isShowDeactive == true)
				{
					tasks =
					   databaseContext.Tasks
					   .ToList()
					   ;
				}

				if (isShowDeactive == false)
				{
					tasks =
						databaseContext.Tasks
						.Where(current => current.IsActive == true)
						.ToList()
						;
				}

				List<Models.ViewModels.TaskViewModel> taskViewModels = new List<Models.ViewModels.TaskViewModel>();

				foreach (var task in tasks)
				{
					var taskStatus =
							databaseContext.TaskStatuses
							.Where(current => current.Id == task.TaskStatusId)
							.FirstOrDefault()
							;

					Models.ViewModels.TaskViewModel taskViewModel = new Models.ViewModels.TaskViewModel();

					taskViewModel.Id = task.Id;
					taskViewModel.InsertDateTime = task.InsertDateTime;
					taskViewModel.Name = task.Name;
					taskViewModel.TaskStatus = taskStatus.Titile;
					taskViewModel.Description = task.Description;
					taskViewModel.StartDate = task.StartDate.Value;
					taskViewModel.EndtDate = task.EndtDate;
					taskViewModel.IsActive = task.IsActive;

					taskViewModels.Add(taskViewModel);

				}

				taskDataGridView.DataSource = taskViewModels;
			}
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (databaseContext != null)
			{
				databaseContext.Dispose();
				databaseContext = null;
			}
		}

		private void TaskDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (taskDataGridView.SelectedRows.Count == 0)
			{
				return;
			}
			else
			{
				if (taskDataGridView.SelectedRows.Count == 1)
				{
					if (taskDataGridView.DataSource is List<Models.ViewModels.TaskViewModel> taskViewModels)
					{
						int selectedIndex =
							taskDataGridView.SelectedRows[0].Index;

						Models.ViewModels.TaskViewModel task =
							taskViewModels[selectedIndex];

						TaskDetailsForm taskDetailsForm = new TaskDetailsForm(task, databaseContext);

						taskDetailsForm.ShowDialog();

						RefreshTaskDataGridView();

					}
				}
				else
				{
					MessageBox.Show("You must select just one item!");
				}
			}

		}

		private void ResetValues()
		{
			nameTextBox.Clear();
			descriptionTextBox.Clear();
			startDateMaskedTextBox.Clear();
		}

		private void taskDataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
		{
			if (sender is DataGridViewRow)
			{
				MessageBox.Show("Test");
			}
		}

		private void isShowDeactiveCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if (isShowDeactiveCheckBox.Checked == true)
			{
				LoadTasks(isShowDeactive: true);
			}
			else
			{
				LoadTasks(isShowDeactive: false);
			}
		}
	}
}
