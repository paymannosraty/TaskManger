using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
	internal class DatabaseContextInitializer :
		System.Data.Entity.DropCreateDatabaseIfModelChanges<DatabaseContext>
	{
		public DatabaseContextInitializer() : base()
		{
		}
		protected override void Seed(DatabaseContext databaseContext)
		{
			databaseContext.TaskStatuses.Add(new TaskStatus() { Titile = "Done" });
			databaseContext.TaskStatuses.Add(new TaskStatus() { Titile = "ToDo" });
		}
	}
}
