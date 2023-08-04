using System.ComponentModel.DataAnnotations;

namespace HelloWorldApp.Models
{
	public class Employee
	{
		[Required(ErrorMessage ="Please Enter Name")]
		[StringLength(30,MinimumLength =5,ErrorMessage ="Invalid Name")]
		public string? Name { get; set; }
		[Required]
		public string? Department { get; set; }
		public bool isActive { get; set; }
		[Required(ErrorMessage ="job title is Missing")]
		public string? JobTitle { get; set; }
		[DataType(DataType.Date)]
		public DateTime BirthDate { get; set; }
		[DataType(DataType.EmailAddress)]
		public string? EmailAddress { get; set; }
		
	}
}
