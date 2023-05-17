namespace Corman.Models
{
	public class User: BaseModel
	{
		public string Email { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public DateOnly BirthDate { get; set; }
		public virtual Location Location { get; set; }
	}
}

