namespace AirBNB.Models;

public class Transaction
{
	public int Id { get; set; }
	public double Amount { get; set; }
	public DateTime Date { get; set; }
	public virtual Reservation Reservation { get; set; }
}
