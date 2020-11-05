using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
	public class DatabaseContext : System.Data.Entity.DbContext
	{
		static DatabaseContext()
		{
			System.Data.Entity.Database.SetInitializer(new DatabaseContextInitializer());
		}

		public DatabaseContext() : base()
		{
		}

		// **********
		public DbSet<Task> Tasks { get; set; }
		// **********

		// **********
		public DbSet<TaskStatus> TaskStatuses { get; set; }
		// **********
	}
}
