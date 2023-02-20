using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using AirBNB.Models.Reviews;
using Azure.Core.GeoJson;

namespace AirBNB.Models;

public class Property
{
	public int ID { get; set; }
	public int NumberOfBedRooms { get; set; } = 1;
	public int NumberOfBeds { get; set; } = 1;
	public int NumberOfBathRooms { get; set; } = 1;
	public int Capacity { get; set; } = 1;
	public bool Accepted { get; set; }=false;
	public string Title { get; set; }
	public string Description { get; set; }
	public float Price { get; set; }
	public int MaxStay { get; set; }
	public int MinStay { get; set; } = 1;
	public DateTime Date { get; set; } = DateTime.Now;
	public Point Cordinates { get; set; }
    public string BuildingNumber { get; set; }
	public string Street { get; set; }
	public int PostalCode { get; set; }
	public double Area { get; set; }
	//Region foriegnkey
	[ForeignKey("Region")]
	public int RegionId { get; set; }
	public virtual Region Region { get; set; }

	//Catogery foriegnkey
	[ForeignKey("Catogery")]
	public int CatogeryId { get; set; }
	public virtual Catogery Catogery { get; set; }
	//User foriegnkey
	public int UserId { get; set; }
	//House Rule Relation
	public virtual ICollection<House_Rule> House_Rules { get; set; } = new HashSet<House_Rule>();
	//Amenty Relation
	public virtual ICollection<Amenty> Amentios { get; set; } = new HashSet<Amenty>();
	//Review relation
	public virtual ICollection<Review> Reviews { get; set; } = new HashSet<Review>();













}
