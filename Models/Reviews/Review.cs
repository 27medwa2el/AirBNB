using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AirBNB.Models.Reviews;

public class Review
{
    public int Id { get; set; }
    public int Rating { get; set; }
    public string Content { get; set; }
    public DateTime Date { get; set; } = DateTime.Now;
    //Property Foriegnkey
    [ForeignKey("Property")]
    public int PropertyId { get; set; }
    public virtual Property Property { get; set; }
    //User Foriegnkey
    public string UserId { get; set; }

}
