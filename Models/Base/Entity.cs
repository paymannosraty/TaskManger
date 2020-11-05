using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Base
{
	public abstract class Entity : object
	{
		public Entity() : base()
		{
			InsertDateTime = System.DateTime.Now;
		}

		// **********
		/// <summary>
		/// شماره منحصر به فرد
		/// </summary>
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]

		[Browsable(false)]
		public int Id { get; set; }
		// **********

		// **********
		/// <summary>
		/// تاریخ و زمان درج اطلاعات
		/// </summary>		
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[Browsable(false)]

		public System.DateTime InsertDateTime { get; set; }
		// **********
	}
}
