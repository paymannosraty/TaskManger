using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ViewModels
{
	public class TaskViewModel : Base.Entity
	{
		public TaskViewModel() : base()
		{
		}


		//**********
		[Required]
		public string Name { get; set; }
		//**********

		//**********
		public string TaskStatus { get; set; }
		//**********

		//**********
		[Browsable(false)]
		public string Description { get; set; }
		//**********


		//**********
		public DateTime? StartDate { get; set; }
		//**********

		//**********
		public DateTime? EndtDate { get; set; }
		//**********
	}
}
