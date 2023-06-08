using System.ComponentModel.DataAnnotations;

namespace ItSupport.Entites
{
	public class Status
	{
		public int Id { get; set; }
		[Required]
		public string StatusName { get; set; } = "გაგზავნილი";
	}
}
