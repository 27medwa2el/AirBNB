using System.ComponentModel.DataAnnotations;

namespace AirBNB.Models;

	public class Catogery
	{
	public int Id { get; set; }
	public string Name { get; set; }
	public string Description { get; set; }
	public virtual ICollection<Property> Properties { get; set; }=new HashSet<Property>();
}

