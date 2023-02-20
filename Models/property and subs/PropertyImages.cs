using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AirBNB.Models;

	public class PropertyImages
	{
	public int Id { get; set; }

	public string URL { get; set; }
	[ForeignKey("Property")]
	public int PropertyID { get; set; }

	public virtual Property Property { get; set; }
}

