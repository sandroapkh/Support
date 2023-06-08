using System.ComponentModel.DataAnnotations;

namespace ItSupport.Entites
{
	public class TechniqueDisc
	{
        public int Id { get; set; }
        [Required]
        public string TechniqueType { get; set; }
        public string Model { get; set; }
        [Required]
        public string ProblemDiscription { get; set; }
        public Status MyProperty { get; set; }
    }
}
