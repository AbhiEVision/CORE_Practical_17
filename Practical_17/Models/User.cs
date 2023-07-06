using System.ComponentModel.DataAnnotations;

namespace Practical_17.Models
{

	public class User
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[StringLength(50)]
		public required string Name { get; set; }

		[Required]
		[StringLength(50)]
		[DataType(DataType.EmailAddress)]
		public required string Email { get; set; }

		[Required]
		[StringLength(50)]
		[DataType(DataType.Password)]
		public required string Password { get; set; }

		public virtual ICollection<UserRole> UserRoles { get; set; }
	}
}
