using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
	public class Task : Base.Entity
	{
		public Task() : base()
		{
		}

		//**********
		//**********
		//**********
		public virtual TaskStatus TaskStatus { get; set; }
		//**********

		//**********
		public int TaskStatusId { get; set; }
		//**********
		//**********
		//**********

		//**********
		[Required]
		public string Name { get; set; }
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
