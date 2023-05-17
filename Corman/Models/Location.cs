namespace Corman.Models;


public class Location: BaseModel
{
  public Double Latitude { get; set;}
  public Double Longitude { get; set;}

  public Guid NeighborhoodId { get; set;}

  public Guid UserId { get; set; }

  public virtual User User { get; set; }

  public virtual Neighborhood Neighborhood { get; set; }
}
