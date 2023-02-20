using System.ComponentModel.DataAnnotations.Schema;

namespace AirBNB.Models;

public class Reservation
{
	public int Id { get; set; }

	public DateTime CheckIn { get; set; }

	public DateTime CheckOut { get; set; }

	public DateTime Date { get; set; } = DateTime.Now;

	public int NOfGuests { get; set; } = 1;

	public bool Accepted { get; set; } = false;

	//User foriegnkey

	public string UserId { get; set; }
	//Property foriegnkey

	[ForeignKey("Property")]
	public int PropertyId { get; set; }
	public virtual Property Property { get; set; }

	public virtual Transaction Transaction { get; set; }
}
