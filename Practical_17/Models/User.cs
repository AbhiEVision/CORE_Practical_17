using System.ComponentModel.DataAnnotations;

namespace Practical_17.Models
{

	public class User
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[StringLength(50)]
		public string Name { get; set; }

		[Required]
		[StringLength(50)]
		[DataType(DataType.EmailAddress)]
		public string Email { get; set; }

		[Required]
		[StringLength(50)]
		[DataType(DataType.Password)]
		public string Password { get; set; }

		public virtual ICollection<UserRole> UserRoles { get; set; }
	}
}
