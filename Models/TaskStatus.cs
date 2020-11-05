using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
	public class TaskStatus: Base.Entity
	{
		public TaskStatus(): base()
		{
		}

		public int MyProperty { get; set; }
		//**********
		//**********
		//**********
		public virtual List<Task> Tasks { get; set; }
		//**********
		[Required]
		public string Titile { get; set; }
		//**********
	}
}
